using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TW.DeveloperTest.Contracts.Logger;

namespace TW.DeveloperTest.Contracts
{
    public class HeadLogger
    {
        public Logger.Debug Debug;
        public Information Information;
        public Warning Warning;
        public Error Error;
        public HeadLogger()
        {
            Debug = new Logger.Debug();
            Information = new Information();
            Warning = new Warning();
            Error = new Error();
        }

        public void GetAllResult<T>()
        {
            throw new NotImplementedException();
        }

        public void GetResult<T>(T LoggerType)
        {
            var type = LoggerType.GetType();
            //search for generic type matching models above and print its logs

            throw new NotImplementedException();
        }
        public void AddLog<T>(T LoggerType)
        {
            throw new NotImplementedException();
        }
        public void RemoveLog<T>(T LoggerType)
        {
            throw new NotImplementedException();
        }
        public void ClearLog<T>(T LoggerType)
        {
            throw new NotImplementedException();
        }
    }
}
