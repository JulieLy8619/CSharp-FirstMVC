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
