using System;
using TodoApp.Model;

namespace TodoApp.Data
{
    public class People
    {
        
        private static Person [] personarray = new Person[] { };

        public int Size()
        {
            return personarray.Length;
        }

        public Person[] FindAll()
        {
            return personarray;
        }

        public Person FindById(int personId)
        {
            Console.WriteLine("Insert person Id: ");

            while (!int.TryParse(Console.ReadLine(), out personId))
            {
                Console.WriteLine("Please insert a number!");
            }

            foreach (var person in personarray)
            {
                if (Person.IdCounter == personId)
                {
                    return person;
                }
            }
            
            return null;
        }
        public static Person[] NewPerson<Person>(this Person[] personarray, Person person)
        {
            if (personarray == null)
            {
                return new Person[] { person };
            }

            Person[] result = new Person[personarray.Length + 1];
            personarray.CopyTo(result, 0);
            result[personarray.Length] = person;

            return result;
        }

        public People()
        {
        }


    }
}
