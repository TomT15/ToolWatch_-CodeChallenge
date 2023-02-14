using System.Collections.Generic;
using System.Diagnostics;

namespace TW.DeveloperTest.Contracts
{
    public interface IWorker
    {
        string GetResult();
        void AddLog();
        void RemoveLog();
        void ClearLog(List<LoggerType> logger);

    }
}
