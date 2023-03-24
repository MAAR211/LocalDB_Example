using Database_Example_3.Models;
using System.Threading.Channels;



namespace DependencyInjectionExample

{

    //Jobseeker Business Logic 

    public class JobseekerBL

    {



        public IJobseekerDAL jobseekerDAL;

        public JobseekerBL(IJobseekerDAL jobseekerDAL)

        {

            this.jobseekerDAL = jobseekerDAL; 


        }


        public List<string> GetAllJobseekerNames()
        {
        //    return jobseekerDAL.SelectAllJobseekers();
         //   return jobseekerDAL.SelectAllJobseekers().Select(j => j.Name).ToList();

            return jobseekerDAL.SelectAllJobseekers()
                .Where(j => j.Name != null)
                .Select(j => j.Name)
                .ToList();


        }


        public int CountJobseekersWithName(string name)
        {
            var jobseekers = jobseekerDAL.SelectAllJobseekers();
            return jobseekers.Count(j => j.Name == name);
        }






    }



}





