using System;
using TodoApp.Model;

namespace TodoApp.Data
{
    public class People
    {
        
        private static Person [] personarray = new Person[] { };

        PersonSequencer newPerson = new PersonSequencer();
        

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
                if (PersonSequencer.nextPersonId() == personId)
                {
                    return person;
                }
            }
            
            return null;
        }


        public static Person NewPerson(String firstName, String lastName)
        {
            Person newPerson = new Person(firstName, lastName);

            int i = 0;
            foreach (Person person in personarray)
            {
                personarray[i] = newPerson;
                i++;
            }
            Person[] result = new Person[personarray.Length + 1];
            personarray.CopyTo(result, 0);
            result[personarray.Length] = newPerson;

            return newPerson;
        }


        //public static Person[] NewPerson<Person>(this Person[] personarray, Person person)
        //{
        //    if (personarray == null)
        //    {
        //        return new Person[] { person };
        //    }

        //    Person[] result = new Person[personarray.Length + 1];
        //    personarray.CopyTo(result, 0);
        //    result[personarray.Length] = person;

        //    return result;
        //}

        public People()
        {
        }


    }
}
