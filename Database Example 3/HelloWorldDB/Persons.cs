﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Example_3.HelloWorldDB
{
    public class Persons
    {

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonID { get; set; }


        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Address { get; set; }

        public string? City { get; set; }



    }
}



