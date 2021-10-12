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
        //public int NextPersonId { get { return nextPersonId();} }

        public static int reset()
        {
            int personId = 0;
            int Id = personId;
            return Id;
        }
        //public int Reset { get { return reset(); } }


        //public PersonSequencer()
        //{

        //    nextPersonId();
        //    Console.WriteLine("The next Person Id is : {0} ", personID);

        //    reset();
        //    Console.WriteLine("Person Id is reset to : {0} ", Id);

        //}
        //public ResetPersonSequencer()
        //{
        //    reset();
        //    Console.WriteLine("Person Id is reset to : {0} ", id);
        //}



    }
}
