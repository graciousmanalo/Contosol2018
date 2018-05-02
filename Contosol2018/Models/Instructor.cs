using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity2018.Models
{
    public class Instructor:Person //Instructor inherits from Person
    {
        //Instructor specific properties
        [Display(Name = "Hire Date")] //always starts [] in annotation
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
       
    }
}
