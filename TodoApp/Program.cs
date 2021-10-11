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
            Person person2 = new Person("Celine", "Alaini");
            
            Console.WriteLine(person1.Information());
            Console.WriteLine();
            Console.WriteLine(person2.Information());
            Console.WriteLine();

            Todo description1 = new Todo();
            Todo description2 = new Todo(2, "Test the calculator App using XUnit");

            Console.WriteLine(description1.Information());
            Console.WriteLine();
            Console.WriteLine(description2.Information());

            Console.ReadKey();
        }
    }
}
