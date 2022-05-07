using SRP_FirstExample_Validate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_FirstExample_Validate
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee newEmployee = new Employee();
            newEmployee.EmployeeId = 1;
            newEmployee.FirstName = "Doruk";
            newEmployee.LastName = "Tonya";
            newEmployee.HireDate = DateTime.Now;

            EmployeeProcessor processor = new EmployeeProcessor();
            string result = processor.InsertEmployee(newEmployee) ? "Succeed" : "Failed";
            Console.WriteLine(result);
            Console.Read();
            
        }
    }
}
