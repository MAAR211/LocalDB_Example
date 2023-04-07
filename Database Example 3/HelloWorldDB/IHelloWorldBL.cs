using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Example_3.HelloWorldDB
{
    public interface IHelloWorldBL
    {
        //  Persons InsertJobseeker(string firstName, string lastName, string address, string city);
        Persons AddJobseeker(Persons newjobseeker);
    }
}
