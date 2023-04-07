using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Example_3.HelloWorldDB
{
    public class DeleteJobseeker //: IHelloWorld
    {

        private readonly HelloWorldContext _db;

        public DeleteJobseeker(HelloWorldContext db)
        {
            _db = db;
        }


        public void RemoveJobseeker(int JobseekerID)
        {
           
         //   var jobseeker = _db.Persons.FirstOrDefault(p => p.FirstName == FirstName);



              var jobseeker = _db.Persons.Find(JobseekerID);

            //var jobseeker = _db.Persons.Where(p => p.FirstName == FirstName);

            //foreach (var j in jobseeker)
            //{
            //    _db.Persons.Remove(j);
            //}



            if (jobseeker == null)
            {
                Console.WriteLine($"Jobseeker with ID {JobseekerID} not found!");
                return;
            }

            _db.Persons.Remove(jobseeker);

            try
            {
                int numOfChanges = _db.SaveChanges();
                if (numOfChanges > 0)
                {
                    Console.WriteLine($"Jobseeker with ID {JobseekerID} deleted successfully!");
                }
                else
                {
                    Console.WriteLine("No changes were made to the context.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }


    }

}

