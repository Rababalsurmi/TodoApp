using System;
namespace TodoApp.Data
{
    public class PersonSequencer
    {
        private static int personId = 0;
        public int personID { get { return personId; } }

        public static int nextPersonId()
        {
            int personID = personId;
            return ++personID;
        }

        public static int reset()
        {
            int personId = 0;
            int Id = personId;
            return Id;
        }
    }
}
