using Database_Example_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static Database_Example_3.HelloWorldDB.HelloWorldDAL;
using Database_Example_3.HelloWorldDB;

namespace Database_Example_3.HelloWorldDB
{
    public class AddJobseeker : IHelloWorld
    {
        private readonly HelloWorldContext _db;

        public AddJobseeker(HelloWorldContext db)
        {
            _db = db;
        }

        public void InsertJobseeker()
        {
            using (var db = new HelloWorldContext())
            {
                var newJobseeker = new Persons
                {
                    City = "Tbilisi",
                    Address = "12 Rustaveli St",
                    FirstName = "Mari",
                    LastName = "Zirakashvili",
                    PersonID = 4,
              
                };

                //_db.Persons.Add(newJobseeker);
                //_db.SaveChanges();


                _db.Persons.Add(newJobseeker);

                try
                {
                    int numOfChanges = _db.SaveChanges();
                    if (numOfChanges > 0)
                    {
                        Console.WriteLine("Jobseeker added successfully!");
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

}

