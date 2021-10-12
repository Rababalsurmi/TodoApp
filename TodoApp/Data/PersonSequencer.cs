using System;
namespace TodoApp.Data
{
    public class PersonSequencer
    {
        private static int personId = 1;
        public int Id { get { return personId; } }
        public int id;

        static int nextPersonId()
        {
            return personId++;
        }
        //public int NextPersonId { get { return nextPersonId();} }

        static int reset()
        {
            int personId = 0;
            int id = personId * 0;
            return id;
        }
        //public int Reset { get { return reset(); } }
       
        public PersonSequencer()
        {
           
            nextPersonId();
            Console.WriteLine("The next Person Id is : {0} ", personId);

            reset();
            Console.WriteLine("Person Id is reset to : {0} ", id);

        }
        //public PersonSequencer(int personId)
        //{
        //    reset();
        //    Console.WriteLine("Person Id is reset to : {0} ", id);
        //}

        //public string PersonIdInformation()
        //{
        //    return $"PersonId Information\n" +
        //        $"id: {personId}\n";
        //}


    }
}
