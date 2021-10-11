using System;
using TodoApp.Model;

namespace TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("------------");
            Person person1 = new Person();
            Console.WriteLine("Person IdCounter:"+Person.IdCounter);
            Person person2 = new Person("Celine", "Alaini");
            
            Console.WriteLine(person1.Information());
            Console.WriteLine();
            Console.WriteLine(person2.Information());

            person1.FirstName = "Tom";

            Console.ReadKey();
        }
    }
}
