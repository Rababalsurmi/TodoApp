using System;
namespace TodoApp.Model
{
    public class Person
    {
        static int idCounter = 0;
        public static int IdCounter { get { return idCounter; } }

        private readonly int personId;
        public int Id { get { return personId; } }

        private String firstName;
        public String FirstName
        {
            get { return firstName; }
            set
            {
                if(value.Equals(""))
                {
                    throw new ArgumentException("Invaild First Name! ");
                }
                firstName = value;
            }
        }
        private String lastName;
        public String LastName
        {
            get { return lastName; }
            set
            {
                if (value.Equals(""))
                {
                    throw new ArgumentException("Invaild Last Name! ");
                }
                lastName = value;
            }
        }

        public Person()
        {
            personId = ++idCounter;
            this.firstName = "John";
            this.lastName = "Andersson";
        }

        public Person(String firstName, String lastName)
        {
            personId = ++idCounter;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string Information()
        {
            return $"Person Information\n" +
                $"id: {personId}\n" +
                $"firstname: {firstName}\n" +
                $"lastname: {lastName}";
        }

        public static implicit operator Person(string v)
        {
            throw new NotImplementedException();
        }
    }
}
