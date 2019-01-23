using System;
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
            //using (StreamReader reader = new StreamReader(~/ personOfTheYear.csv)) ;
            //{
            //}
            //gregory said ok to do this for now but shouldn't hard code info
            //from gwen's thing on slack but doesn't work for me, it breaks thh following then: 
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../wwwroot/personOfTheYear.csv");
            string[] linesFromFile = File.ReadAllLines(path);
            //verified have array of data, they are arrays of arrays/
            var csv = from line in linesFromFile select line.Split(',').ToArray();
            
            var csvStringArray = csv.ToArray();
            //var csvStringArrayArray = csvStringArray.ToArray();
            List<TimePerson> person = new List<TimePerson>();
            //have to use double for loop, also note to start the outside loop at 1 because 0 is the heading information
            for (int i = 1; i < csvStringArray.Length; i++)
            {
                //for (int j = 0; j < csvStringArray[0].Length; j++)
                //{
                    TimePerson tp = new TimePerson();
                    tp.Year = Convert.ToInt32(csvStringArray[i][i+1]);
                    tp.Honor = item[2];
                    tp.Name = item[3];
                    tp.Country = item[4];
                    tp.BirthYear = Convert.ToInt32(item[5]);
                    tp.DeathYear = Convert.ToInt32(item[6]);
                    tp.Title = item[7];
                    tp.Category = item[8];
                    tp.Context = item[9];

                //}
            }
                person.Add(tp);
            }
            return null;
            //linesFromFile.SetDelimiters(new string[] { "," });

            //hints: 
            //file.readalllines in an array
            //iterate through array and set values to the new TimePerson object
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
