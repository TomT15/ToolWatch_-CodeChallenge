using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TW.DeveloperTest.Contracts
{
    public class LoggerInformation
    {
        public string name;
        public string description;
        public LoggerInformation() { }
        public LoggerInformation(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
    }
}
