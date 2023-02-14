using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TW.DeveloperTest.Contracts
{
    public abstract class LoggerBase
    {
        public string name;
        public string description;

        public LoggerBase(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
    }
}
