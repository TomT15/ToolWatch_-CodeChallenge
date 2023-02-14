using System;

namespace TW.DeveloperTest.Contracts
{
    public interface ILoggerInfo
    {
        void GetAllResult<T>();
        void GetResult<T>(T LoggerType);
        void AddLog<T>(T LoggerType);
        void RemoveLog<T>(T LoggerType);
        void ClearLog<T>(T LoggerType);
    }
}