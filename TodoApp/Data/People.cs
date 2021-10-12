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
            foreach (var person in personarray)
            {
                Console.WriteLine(person);
                
            }
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
                if(Person.Id == personId)
                {
                    return person;
                }
            }
            
            return null;
        }
        public People()
        {
            var personFound = FindById(2);
        }
    }
}
