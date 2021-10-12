using System;
using TodoApp.Model;
namespace TodoApp.Data
{
    public class People
    {
        
        private static Person [] array = new Person[] { };

        public int Size()
        {
            return array.Length;
        }
        public Person[] FindAll()
        {
            return Console.WriteLine("[{0}]", string.Join(", ", array));  
        }
        public Person FindById(int personId)
        {
            Console.WriteLine("Insert person Id: ");

            int id;

            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Please insert a number!");
            }

            foreach (var i in array)
            {
                if(Person.Id == id)
                {
                    return i;
                }
            }
            
            return null;
        }
        public People()
        {
            var personFound =FindById(2);
        }
    }
}
