using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Example_3.HelloWorldDB
{
    public class HelloWorldBL : IHelloWorldBL
    {

        private readonly IHelloWorldDAL _hwDAL;

        public HelloWorldBL(IHelloWorldDAL hwDAL)
        {
            _hwDAL = hwDAL;
        }



        public Persons AddJobseeker(Persons newJobseeker)
        {

            int maxPersonID = _hwDAL.GetMaxPersonID();

            newJobseeker.PersonID = maxPersonID + 1;


            Persons existingJobseeker;
            do
            {
                existingJobseeker = _hwDAL.GetJobseekerByID(newJobseeker.PersonID);
                if (existingJobseeker != null)
                {
                    newJobseeker.PersonID++;
                }
            } while (existingJobseeker != null);

            return _hwDAL.AddJobseeker(newJobseeker);
        }

    



        //public Persons InsertJobseeker(string firstName, string lastName, string address, string city)
        //{
        //    int maxPersonID = _hwDAL.GetMaxPersonID();


        //    var newJobseeker = new Persons
        //    {
        //        City = city,
        //        Address = address,
        //        FirstName = firstName,
        //        LastName = lastName,
        //        PersonID = maxPersonID + 1
        //    };

        //    Persons existingJobseeker;
        //    do
        //    {
        //        existingJobseeker = _hwDAL.GetJobseekerByID(newJobseeker.PersonID);
        //        if (existingJobseeker != null)
        //        {
        //            newJobseeker.PersonID++;
        //        }
        //    } while (existingJobseeker != null);

        //    return _hwDAL.AddJobseeker(newJobseeker);
        //}




        //Simple Query- s gamoyenebit
        //using (SqlConnection connection = new SqlConnection("Server=.;Database=HelloWorld;persist security info=True;Integrated Security=True;TrustServerCertificate=True"))
        //{
        //    connection.Open();

        //    string query = "INSERT INTO Persons (PersonID, LastName, FirstName,Address, City) VALUES ('12', 'Smith', 'John', 'Street 123', 'New York')";

        //    SqlCommand command = new SqlCommand(query, connection);
      
        //}

    }



}












    //

    //    public class JobseekerService
    //    {
    //        private readonly IHelloWorldDAL _db;


    //        public JobseekerService(IHelloWorldDAL db)
    //        {
    //            _db = db;
    //        }


    //        public Persons InsertJobseeker(string firstName, string lastName, string address, string city)
    //        {
    //            int maxPersonID = _db.GetMaxPersonID();

    //            var newJobseeker = new Persons
    //            {
    //                City = city,
    //                Address = address,
    //                FirstName = firstName,
    //                LastName = lastName,
    //                PersonID = maxPersonID + 1
    //            };

    //            Persons existingJobseeker;
    //            do
    //            {
    //                existingJobseeker = _db.GetJobseekerByID(newJobseeker.PersonID);
    //                if (existingJobseeker != null)
    //                {
    //                    newJobseeker.PersonID++;
    //                }
    //            } while (existingJobseeker != null);

    //            return _db.AddJobseeker(newJobseeker);


    //        }





















    //public void InsertJobseeker()
    //{


    //        int maxPersonID = _db.GetMaxPersonID();



    //        var newJobseeker = new Persons
    //        {
    //            City = "Tbilisi",
    //            Address = "12 Rustaveli St",
    //            FirstName = "Mari",
    //            LastName = "Zirakashvili",
    //            PersonID = maxPersonID + 1,  //1 

    //        };


    //    Persons existingJobseeker;
    //    do
    //    {
    //        existingJobseeker = _db.GetJobseekerByID(newJobseeker.PersonID);
    //        if (existingJobseeker != null)
    //        {
    //            newJobseeker.PersonID++;
    //        }
    //    } while (existingJobseeker != null);

    //    return _db.AddJobseeker(newJobseeker);


    //}





    //Console.WriteLine($"maxPersonID  {maxPersonID}");

    //        while (true)
    //        {
    //            var existingJobseeker = hwc.Persons.FirstOrDefault(p => p.PersonID == newJobseeker.PersonID);

    //            if (existingJobseeker == null)
    //            {
    //                hwc.Persons.Add(newJobseeker);
    //                break; // Exit the loop
    //            }




    //            else
    //            {
    //                maxPersonID++;
    //            }
    //        }

    //        _db.Persons.Add(newJobseeker);

    //        try
    //        {
    //            int numOfChanges = _db.SaveChanges();


    //            if (numOfChanges > 0)
    //            {
    //                Console.WriteLine("Jobseeker added successfully!");
    //            }
    //            else
    //            {
    //                Console.WriteLine("No changes were made to the context.");
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine($"An error occurred: {ex.Message}");
    //        }

    //    }





