using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_3_BasicAuthenticationWEBAPI.Models
{
    public class EmployeeBL
    {
        public List<Employee> GetEmployees()
        {
            // to keep focus on Basic Authentication
            // Here we hardcoded the data
            String MS = "";
            String DT = "";
            List<Employee> empList = new List<Employee>();
            // this is a random generator assigned to the new variables below including the array
            Random generator = new Random();
            // this is an array to randomly assign one of these elements as a department for a user
            string[] dept_array = { "Marketing", "IT", "HR", "Technical" };
            for (int i = 0; i < 20; i++)
            {
                // random generator is assigned to each new variable
                int new_age = generator.Next(20, 30);
                int new_marital = generator.Next(1, 3);
                int new_salary = generator.Next(50000, 120000);
                int new_dept = generator.Next(1, 5);
                // user is randomly assigned as Married or Single
                switch (new_marital)
                {
                    case 1:
                        MS = "Married";
                        break;
                    case 2:
                        MS = "Single";
                        break;
                }
                // user is randomly assigned one of these departments
                switch (new_dept)
                {
                    case 1:
                        DT = dept_array[0];
                        break;
                    case 2:
                        DT = dept_array[1];
                        break;
                    case 3:
                        DT = dept_array[2];
                        break;
                    case 4:
                        DT = dept_array[3];
                        break;
                }
                // more than 10 users (up to 20) will be male with these fields
                if (i > 10)
                {
                    empList.Add(new Employee()
                    {
                        ID = i,
                        Name = "Name" + i,
                        Age = new_age,
                        Dept = DT,
                        Salary = new_salary,
                        Gender = "Male",
                        Address = "Address" + i,
                        Phone = 416555500 + i,
                        Marital_Status = MS
                    });
                }
                // less than 10 users will be female with these fields
                else
                {
                    empList.Add(new Employee()
                    {
                        ID = i,
                        Name = "Name" + i,
                        Age = new_age,
                        Dept = DT,
                        Salary = new_salary,
                        Gender = "Female",
                        Address = "Address" + i,
                        Phone = 416555500 + i,
                        Marital_Status = MS
                    });
                }
            }
            return empList;
        }
    }
}