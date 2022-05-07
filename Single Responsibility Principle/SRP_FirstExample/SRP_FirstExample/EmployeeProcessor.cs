using SRP_FirstExample.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_FirstExample
{
    public class EmployeeProcessor
    {
        //When we look at the operations below, we see that more than one job is done in our adding code that working in the class. Both insertion and log operations are performed at once. For this reason, it contradicts the SRP principle. 
        public void InsertEmployee(Employee employee)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                sb.Append(employee.EmployeeId);
                sb.AppendLine();
                sb.Append(employee.FirstName);
                sb.AppendLine();
                sb.Append(employee.LastName);
                sb.AppendLine();
                sb.Append(employee.HireDate);
                sb.AppendLine();
                File.WriteAllText("C:\\Users\\User\\Desktop\\Employee.txt", sb.ToString());

                Console.WriteLine("Personel is added to db.");
                Console.Read();
            }
            catch (Exception ex)
            {

                sb = new StringBuilder();
                sb.Append("Error");
                sb.AppendLine();
                sb.Append(ex.Message);
                sb.AppendLine();
                File.WriteAllText("C:\\Users\\User\\Desktop\\Employee.txt", sb.ToString());

                Console.WriteLine("Error!");
                Console.ReadKey();

            }
        }
    }
}
