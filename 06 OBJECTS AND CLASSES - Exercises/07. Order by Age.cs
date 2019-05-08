using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            while (true)
            {
                string command = Console.ReadLine();

                if(command == "End")
                {
                    break;
                }

                List<string> personInfo = command.Split(' ').ToList();

                string name = personInfo[0];
                string id = personInfo[1];
                int age = int.Parse(personInfo[2]);

                persons.Add(new Person(name, id, age));
            }

            List<Person> sortedPersonsByAge = persons.OrderBy(order => order.Age).ToList();

            foreach(Person person in sortedPersonsByAge)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }

    class Person
    {
        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }

        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Age = age;
            this.ID = id;
        }
    }
}
