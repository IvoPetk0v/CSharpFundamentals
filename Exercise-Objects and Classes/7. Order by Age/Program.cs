using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Passport> listOfPassports = new List<Passport>();
            List<int> listofIDs = new List<int>();
            while ((input = Console.ReadLine()) != "End")
            {

                string[] infoArg = input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                string name = infoArg[0];
                int id = int.Parse(infoArg[1]);
                int age = int.Parse(infoArg[2]);
                if (!listofIDs.Contains(id))
                {
                    Passport currPasspor = new Passport(name, id, age);
                    listOfPassports.Add(currPasspor);
                    listofIDs.Add(id);
                }
                else
                {
                    foreach (var item in listOfPassports)
                    {
                        if (item.ID == id)
                        {
                            item.Name = name;
                            item.Age = age;
                        }
                    }
                }
            }
            List<Passport> orderedListOfPassports = listOfPassports.OrderBy(x => x.Age).ToList();
            Console.WriteLine(String.Join(Environment.NewLine, orderedListOfPassports));

        }
    }
    public class Passport
    {
        public Passport(string name, int id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public string Name { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{this.Name} with ID: {this.ID} is {this.Age} years old.";
        }
    }
}
