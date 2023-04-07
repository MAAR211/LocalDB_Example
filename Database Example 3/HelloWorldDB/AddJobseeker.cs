using Database_Example_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static Database_Example_3.HelloWorldDB.HelloWorldDAL;
using Database_Example_3.HelloWorldDB;
using System.Xml.Linq;

namespace Database_Example_3.HelloWorldDB
{
    public class AddJobseeker //: IHelloWorld
    {

        //readonly - mxolod ertxel unda moxdes mnishvnelobis minicheba, an gamocxadebisas an konstruqtorshi
        //   _value  - private mnishvneloba
        private readonly HelloWorldContext _db;


        public AddJobseeker(HelloWorldContext db)
        {
            _db = db;
        }

        public void InsertJobseeker()
        {
            //using (var database = new HelloWorldContext())
            //{
            //    var newJobseeker = new Persons
            //    {
            //        City = "Tbilisi",
            //        Address = "12 Rustaveli St",
            //        FirstName = "Mari",
            //        LastName = "Zirakashvili",
            //        PersonID = 4,

            //    };

           
            //am xazis gareshe rom davwero??
            using (var hwc = new HelloWorldContext()) {


                // maximum PersonID mnishvneloba Persons cxrilidan
                int maxPersonID = hwc.Persons.Max(p => p.PersonID);


                var newJobseeker = new Persons
                {
                    City = "Tbilisi",
                    Address = "12 Rustaveli St",
                    FirstName = "Mari",
                    LastName = "Zirakashvili",
                    PersonID = maxPersonID + 1,  //1 
                    
                };


                Console.WriteLine($"maxPersonID  {maxPersonID}");
             
                //foreach (var person in hwc.Persons)
                //{
                //    Console.WriteLine("{0}", person.PersonID);
                //}

                while (true)
            {
               // PersonID mnishvnelobis gazrda ertit
               //PersonID dublikati ar iqneba 

          //    newJobseeker.PersonID = maxPersonID + 1;

 //FirstOrDefault - abrunebs pirvel an default mnishvnelobas - tu shedegi ar moidzebna an carielia sia             
//mag. int[] numbers = new int[0]; - daabrunebs 0, FirstOrDefault - daabrunebs false,

//p => p.PersonID == newJobseeker.PersonID - igive PersonID it rac newJobseekeris arsebobs tu ara cxrilshi
               var existingJobseeker = hwc.Persons.FirstOrDefault(p => p.PersonID == newJobseeker.PersonID);

//tu igive PersonID it ar arsebobs chanaweri
                if (existingJobseeker == null) 
                {
                        hwc.Persons.Add(newJobseeker);
                    break; // Exit the loop
                }
                
                    
 //tu arsebobs, maxPersonID-is moemateba erti           
                else
                {
                    maxPersonID++; 
                }
            }

//hwc - lokaluri cvladi iyo, cvlileba ar sheinaxeba tu _db cvladze ar davwer am xazs da mere SaveChanges
//hwc cvladis gareshe pirdapir es rom davwero?
                _db.Persons.Add(newJobseeker);

                try
                {

// The SaveChanges method of the DbContext saves changes to the made to the entities to the database
// Returns - Int32   -  The number of objects in an Added, Modified, or Deleted state when SaveChanges() was called.
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



/*
  using (var hwc = new HelloWorldContext())
{
   var newJobseeker = new Persons
     {
              City = "Tbilisi",
                  
            FirstName = "Mari",
            LastName = "Zirakashvili",
            PersonID = maxPersonID + 1,  //1 

//meore cxrili rom mqondes Address 
            Address = new Address
          {
            Street = "123 Main St",
            City = "Anytown",
            State = "CA",
            ZipCode = "12345"
          }
               
      };

    context.People.Add(newJobseeker);
    context.SaveChanges();
}

*/