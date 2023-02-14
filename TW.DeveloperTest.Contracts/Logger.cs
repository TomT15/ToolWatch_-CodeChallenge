using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TW.DeveloperTest.Contracts
{
    public class Logger : ILogger
    {
        List<LoggerInformation> Debug;
        List<LoggerInformation> Information;
        List<LoggerInformation> Warning;
        List<LoggerInformation> Error;
        public Logger()
        {
            Debug = new List<LoggerInformation>();
            Information = new List<LoggerInformation>();
            Warning = new List<LoggerInformation>();
            Error = new List<LoggerInformation>();
        }

        public void AddLog()
        {
            throw new NotImplementedException();
        }

        public void ClearLog(List<LoggerInformation> logger)
        {
            throw new NotImplementedException();
        }

        public string GetResult()
        {
            throw new NotImplementedException();
        }

        public void RemoveLog()
        {
            throw new NotImplementedException();
        }
    }
}
