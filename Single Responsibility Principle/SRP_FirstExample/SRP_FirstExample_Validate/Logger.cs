using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_FirstExample_Validate
{
    public class Logger
    {
        public void LogFile(string path, string log)
        {
            File.WriteAllText(path, log);
        }

        public string BuildLog(string information)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Date: ");
            sb.Append(DateTime.Now);
            sb.AppendLine();
            sb.Append("Info: ");
            sb.Append(information);
            return sb.ToString();
        }
    }
}
