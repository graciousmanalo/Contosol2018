using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity2018.Models
{
    public abstract class Person
    {
        //Person properties - characteristics (data attributes)

            /*
             * These properties will become database fields within the Person table by using
             * the Entity Framework Core
             * The ID Property will become the Primary Key Column of the database table that 
             * correspondes to the this class (Person)
             * By default the EF interprets a property that's named ID or ClassNameID as the PK
             * For example:
             *  - ID
             *  - PersonID
             */
        public int ID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
        public string Province { get; set; }

        //Read Only properties
        [Display(Name = "Name")] //always starts [] in annotation
        public string FullName
        {
            get 
            {
                return LastName + ", " + FirstName;
            }
        }

        public string IDFullName
        {
            get
            {
                return "(" + ID + ")" + LastName + ", " + FirstName;
            }
        }
    }
}
