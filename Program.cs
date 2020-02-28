using System;
using System.Collections.Generic;

namespace listIntro {
    class Program {
        static void Main (string[] args) {
            List<string> nssCohorts = new List<string> {
                "Cohort 36",
                "Cohort 37",
                "Cohort 38",
                "Cohort 39"
            };

            nssCohorts.Add ("Cohort 39");

            List<int> birthYears = new List<int> {
                1996,
                1997,
                1992,
                2001
            };

            birthYears.Add (1999);
            birthYears.Add (1989);
            birthYears.Add (1988);
            birthYears.Add (1987);

            foreach (string cohort in nssCohorts) {
                Console.WriteLine (cohort);
            }

            birthYears.Remove (1996);

            foreach (int year in birthYears) {
                Console.WriteLine (year);
                if (year == 1996) {
                    Console.WriteLine ("GO BULLS");
                }
            }

            Console.WriteLine ("Hello World!");

            //Dictionaries
            Dictionary<string, string> student = new Dictionary<string, string> ();

            student.Add ("Name", "Adam");
            student.Add ("Cohort", "Day 37");

            Dictionary<string, string> anotherStudent = new Dictionary<string, string> () { { "Name", "Brenda" }, { "Cohort", "Day 37" }
            };

        }
    }
}