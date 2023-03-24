using Database_Example_3.Models;
using System.Threading.Channels;



namespace DependencyInjectionExample

{

   
    public interface IJobseekerDAL

    {

        List<Jobseeker> SelectAllJobseekers();

    }



    //Jobseeker Data Access Layer 

    public class JobseekerDAL : IJobseekerDAL

    {

        public List<Jobseeker> SelectAllJobseekers()

        {



            List<Jobseeker> jobseekers = new List<Jobseeker>();

            using (var db = new Hrrav3GeNextPreprodContext())
            {
                jobseekers = db.Jobseekers.ToList();
            }

            return jobseekers;

        }



    }



}



