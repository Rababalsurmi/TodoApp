using System;
namespace TodoApp.Data
{
    public class PersonSequencer
    {
        private static int personId = 0;
        public int PersonId
        {
            get { return personId; }
            set { personId = value; }
        }

        public static int nextPersonId()
        {
            return ++personId;
        }

        public static int reset()
        {
            int personId = 0;
            //int Id = personId;
            return personId;
        }

    }
}
