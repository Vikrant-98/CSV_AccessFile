﻿using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace CSV_AccessFile
{
    class Program
    {
        /// <summary>
        /// Main method read the data from file
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\The Daddy\source\repos\CSV_AccessFile\CSV_AccessFile\Text.txt";
            List<Person> people = new List<Person>();
            List<string> lines = File.ReadAllLines(filepath).ToList();
            foreach (string line in lines)
            {
                String[] entries = line.Split(',');

                Person newPerson = new Person();

                newPerson.Name = entries[0];
                newPerson.Phone = entries[1];
                newPerson.Email = entries[2];
                newPerson.Country = entries[3];

                people.Add(newPerson);
            }
            foreach (var person in people)
            {
                Console.WriteLine($"{ person.Name } { person.Phone } : { person.Email } { person.Country }");
            }
            //New Data added in file
            Console.WriteLine("--------------------------------------------------------------------");
            people.Add(new Person { Name = "Aditya" , Phone = "9128933564", Email = "Adtiyas.kulkarni@gmail.com" , Country = "USA"});
            List<string> output = new List<string>();
            foreach (var person in people)
            {
                output.Add($"{ person.Name },{ person.Phone },{ person.Email },{ person.Country }");
            }
            Console.WriteLine("Writing into the file");
            File.WriteAllLines(filepath, output);
            foreach (var person in people)
            {
                Console.WriteLine($"{ person.Name } { person.Phone } : { person.Email } : { person.Country }");
            }
        }
    }
}
