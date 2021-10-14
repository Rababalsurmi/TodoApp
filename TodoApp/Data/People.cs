using System;
using TodoApp.Model;

namespace TodoApp.Data
{
    public class People
    {
        
        private static Person [] personarray = new Person[] { };


        PersonSequencer newPerson = new PersonSequencer();
        Person Person = new Person();


        public int Size(Person[] personarray)
        {
            return personarray.Length;
        }

        public Person[] FindAll(Person[] personarray)
        {
            return personarray;
        }

        public Person FindById(int personId)
        {
            foreach (Person person in personarray)
            {
                var check = Array.Exists(personarray, personId => personId == person);
                if (check == true)
                {
                    Console.WriteLine("{0} found in the array");
                    return person;
                }  
            }

            Console.WriteLine("Value not found");

            return null; 
        }


        public static Person NewPerson(String firstName, String lastName)
        {
            int personId = 0;
            personId = PersonSequencer.nextPersonId();

            Person newPerson = new Person(firstName, lastName, personId);


            Array.Resize(ref personarray, personarray.Length + 1);

            Person[] result = new Person[personarray.Length + 1];

            for (int i = 0; i < personarray.Length; i++)
            {
                int x = 5;
                if (i < x - 1)
                    result[i] = personarray[i];
                else if (i == x - 1)
                    result[i] = newPerson;
                else
                    result[i] = personarray[i - 1];
            }
            //personarray.CopyTo(result, 0);
            //result[personarray.Length] = newPerson;

            return newPerson;
        }

        public void Clear()
        {
            Array.Clear(personarray, 0, personarray.Length);
            
            //Person[] personarray = Array.Empty<Person>();
        }
    }
}
