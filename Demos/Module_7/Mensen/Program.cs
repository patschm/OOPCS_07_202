using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mensen
{
    class Program
    {
        static List<Person> people = new List<Person>();

        static string OrderByLastName(Person p)
        {
            return p.LastName;
        }
        static int OrderByAge(Person p)
        {
            return p.Age;
        }
        static bool LastNameStartsWithD(Person p)
        {
            return p.LastName.StartsWith("D");
        }

        static void Main(string[] args)
        {
            InitList();
            string fl = "C";

            var query = people
                .OrderBy(OrderByAge)
                .Where(p => p.LastName.StartsWith(fl))
                .Skip(3)
                .Take(7);

            var q2 = from p in people
                     where p.LastName.StartsWith("F")
                     orderby p.FirstName descending
                     select p;

            ShowPeople(q2.Take(5).ToList());
        }

        private static void ShowPeople(List<Person> plist)
        {
            foreach(Person p in plist)
            {
                Console.WriteLine(p);
            }
        }

        private static void InitList()
        {
            people = new Faker<Person>()
                .RuleFor(p => p.FirstName, f => f.Name.FirstName())
                .RuleFor(p => p.LastName, f => f.Name.LastName())
                .RuleFor(p => p.Age, f => f.Random.Number(0, 123))
                .Generate(1000)
                .ToList();
        }
    }
}
