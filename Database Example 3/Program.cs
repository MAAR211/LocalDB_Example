using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Database_Example_3.HelloWorldDB;
using Database_Example_3.Models;
using DependencyInjectionExample;
using Microsoft.Data.SqlClient;
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



            IHelloWorldDAL personDAL = new HelloWorldDAL(new HelloWorldContext());
            HelloWorldBL personBL = new HelloWorldBL(personDAL);


            Persons newJobseeker = new Persons
            {
                FirstName = "Jane",
                LastName = "Doe",
                Address = "123 Main St",
                City = "Anytown"
            };

            personBL.AddJobseeker(newJobseeker);

         //   personBL.InsertJobseeker("John", "Doe", "123 Main St", "Anytown");
           
           

            Console.WriteLine("New jobseeker inserted successfully");

          















            //using (var db = new HelloWorldContext())
            //{
            //    // Remove NULL values
            //    db.Database.ExecuteSqlRaw("DELETE FROM Persons WHERE PersonID IS NULL OR LastName IS NULL OR FirstName IS NULL OR Address IS NULL OR City IS NULL");

            //    // Remove duplicate rows
            //    //    db.Database.ExecuteSqlRaw("DELETE FROM Persons WHERE PersonID NOT IN (SELECT MIN(PersonID) FROM Persons GROUP BY FirstName, LastName, Address, City)");
            //   // db.Database.ExecuteSqlRaw("WITH CTE AS (SELECT ROW_NUMBER() OVER(PARTITION BY FirstName, LastName, Address, City ORDER BY PersonID) AS RowNum FROM Persons) DELETE FROM CTE WHERE RowNum > 1");




            //    db.Database.ExecuteSqlRaw("DELETE FROM Persons WHERE PersonID = {0}", 4);
            //}









            //  using (var db = new HelloWorldContext())
            //  {



            //      //    var addJobseeker = new AddJobseeker(db);
            // //     addJobseeker.InsertJobseeker();

            // //     var delJobseeker = new DeleteJobseeker(db);
            ////     delJobseeker.RemoveJobseeker(12);




            //  }





            //RelatedClasses rc = new RelatedClasses();
            //rc.JobseekerRelatedClasses();

            Console.ReadKey();

            }

        }
    }
