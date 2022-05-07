using SRP_FirstExample_Validate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_FirstExample_Validate
{
    public class EmployeeProcessor
    {
        Logger logger;
        string log;

        public EmployeeProcessor()
        {
            logger = new Logger();
        }

        public bool InsertEmployee(Employee employee)
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
                log = logger.BuildLog(sb.ToString());
                logger.LogFile("C:\\Users\\User\\Desktop\\Employee.txt", log);
                return true;
            }
            catch (Exception ex)
            {

                sb.Append("Error");
                sb.AppendLine();
                sb.Append(ex.Message);
                sb.AppendLine();
                log = logger.BuildLog(sb.ToString());
                logger.LogFile("C:\\Users\\User\\Desktop\\Employee.txt", log);
                return false;
            }
        }
    }
}
