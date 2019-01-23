﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace lab11FirstMVC.Models
{
    public class TimePerson
    {
        public int Year { get; set; }
        public string Honor { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Context { get; set; }

        public static List<TimePerson> GetPersons(int begYear, int endYear)
        {

            //read in file
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../wwwroot/personOfTheYear.csv");
            string[] linesFromFile = File.ReadAllLines(path);
            //verified have array of data, they are arrays of arrays/
            var csv = from line in linesFromFile select line.Split(',').ToArray();
            //to make it an array of just the results
            var csvStringArray = csv.ToArray();

            //assign information to objects
            List<TimePerson> person = new List<TimePerson>();
            for (int i = 1; i < csvStringArray.Length; i++)
            {
                TimePerson tp = new TimePerson();
                tp.Year = Convert.ToInt32(csvStringArray[i][0]);
                tp.Honor = csvStringArray[i][1];
                tp.Name = csvStringArray[i][2];
                tp.Country = csvStringArray[i][3];
                if (csvStringArray[i][4] == "")
                {
                    tp.BirthYear = 0;
                }
                else
                {
                    tp.BirthYear = Convert.ToInt32(csvStringArray[i][4]);
                }
                if (csvStringArray[i][5] == "")
                {
                    tp.DeathYear = 0;
                }
                else
                {
                    tp.DeathYear = Convert.ToInt32(csvStringArray[i][5]);
                }
                tp.Title = csvStringArray[i][6];
                tp.Category = csvStringArray[i][7];
                tp.Context = csvStringArray[i][8];
                person.Add(tp);
            }
            return person;

            //hints: 
            //reminder csv is seperated by a comma
            //populate list with all the peoples of the csv
            //then linq as needed (amanda suggests with lambda
            //list<timepersons> listofpeople = people.where (p => p.year >= begyear and p.year <= end year)).tolist();
            //return listofpeople
            //can fill in blank space with 0, and then if it says 0 to put in N/A
            //example
            //list<timeperson> person = new list<timeperson>();
            //person.add(); //add is built into list

        }
    }
}
