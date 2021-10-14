using System;
using TodoApp.Data;
namespace TodoApp.Model
{
    public class Person
    {

        private readonly int personId;
        public int PersonId { get { return personId; } }

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
            this.firstName = "";
            this.lastName = "";
        }

        public Person(String firstName, String lastName, int personId)
        {
            personId = PersonSequencer.nextPersonId();

            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Person(String firstName, String lastName)
        {
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
    }
}
