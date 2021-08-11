using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_3_BasicAuthenticationWEBAPI.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        // Age is new
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Dept { get; set; }
        public int Salary { get; set; }
        // Address is new
        public string Address { get; set; }
        // Phone is new
        public int Phone { get; set; }
        // Martial_Status is new
        public string Marital_Status { get; set; }
    }
}