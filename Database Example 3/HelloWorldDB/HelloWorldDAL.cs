using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Database_Example_3.HelloWorldDB.HelloWorldDAL;

namespace Database_Example_3.HelloWorldDB
{
    public class HelloWorldDAL : IHelloWorldDAL
    {
       
            private readonly HelloWorldContext _db;

            public HelloWorldDAL(HelloWorldContext db)
            {
                _db = db;
            }


        public Persons AddJobseeker(Persons person)
        {
            _db.Persons.Add(person);
            _db.SaveChanges();
            return person;
        }

        public int GetMaxPersonID()
        {
            return _db.Persons.Any() ? _db.Persons.Max(p => p.PersonID) : 0;
        }



        public Persons GetJobseekerByID(int personID)
        {
            return _db.Persons.FirstOrDefault(p => p.PersonID == personID);
        }

    

        //public int GetMaxPersonID()
        //{
        //    return _db.Persons.Max(p => p.PersonID);
        //}

        //public Persons AddJobseeker(Persons jobseeker)
        //{
        //    _db.Persons.Add(jobseeker);
        //    _db.SaveChanges();
        //    return jobseeker;
        //}

        //public Persons GetJobseekerByID(int id)
        //{
        //    return _db.Persons.FirstOrDefault(p => p.PersonID == id);
        //}




    }
}
