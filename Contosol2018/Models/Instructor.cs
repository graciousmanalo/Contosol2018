using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity2018.Models
{
    public class Instructor:Person //Instructor inherits from Person
    {
        //Instructor specific properties
        public DateTime HireDate { get; set; }
       
    }
}
