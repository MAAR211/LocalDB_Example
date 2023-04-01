using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Database_Example_3.HelloWorldDB;
using Database_Example_3.Models;
using DependencyInjectionExample;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;


namespace Database_Example3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //var configuration = new ConfigurationBuilder()
            //    .AddJsonFile("appsettings.json")
            //    .Build();
            //var dbContext = new MyDbContext(configuration);


            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //using (var db = new Hrrav3GeNextPreprodContext())
            //{

            //    var jobseekerNames = db.Jobseekers.Select(j => j.Name).ToList();

            //    foreach (var name in jobseekerNames)
            //    {
            //        Console.WriteLine(name);
            //    }
            //}



            var jobseekerBL = new JobseekerBL(new JobseekerDAL());
            var jobseekerNames = jobseekerBL.GetAllJobseekerNames();
            foreach (var name in jobseekerNames)
            {

                Console.WriteLine(name);

            }

            int JobseekerCount = jobseekerBL.CountJobseekersWithName("Mariam");
            Console.WriteLine(JobseekerCount);





            //AddJobseeker example = new AddJobseeker();
            //example.InsertJobseeker();


            using (var db = new HelloWorldContext())
            {
                var addJobseeker = new AddJobseeker(db);
                addJobseeker.InsertJobseeker();
            }


            //RelatedClasses rc = new RelatedClasses();
            //rc.JobseekerRelatedClasses();

            Console.ReadKey();

            }

        }
    }
