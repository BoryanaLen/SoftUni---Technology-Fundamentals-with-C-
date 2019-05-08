using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Oldest_Family_Member
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());

            Family myFamily = new Family();

            for (int i = 0; i <numberLines; i++)
            {
                List<string> personInfo = Console.ReadLine().Split(' ').ToList();

                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);

                Person newPerson = new Person(name, age);

                myFamily.AddMember(newPerson);
            }

            Person oldestPerson =  myFamily.GetOldestMember();

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }

    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }
    }

    class Family
    {
        public List<Person> listOfPeople { get; set; }

        public Family()
        {
            listOfPeople = new List<Person>();
        }

        public void AddMember(Person member)
        {
            listOfPeople.Add(member);
        }

        public Person GetOldestMember()
        {
            List<Person> orderedPeopleByAgeDescending = this.listOfPeople
                .OrderByDescending(order => order.Age).ToList();

            return orderedPeopleByAgeDescending[0];
        }
    }
}
