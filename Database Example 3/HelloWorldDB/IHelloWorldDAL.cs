using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Example_3.HelloWorldDB
{

    public interface IHelloWorldDAL

    {
        Persons AddJobseeker(Persons jobseeker);

        int GetMaxPersonID();
        
        Persons GetJobseekerByID(int id);


        //    void Add(Persons person);
        //    Persons GetById(int id);
        //    void Update(Persons person);
        //    void Delete(Persons person);
        //    //    void InsertJobseeker();
        //}

    }
    
}
