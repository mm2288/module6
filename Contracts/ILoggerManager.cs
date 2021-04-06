using System;
namespace Contracts
{
    public interface ILoggerManager
    {
        void LogInfo(string message);
<<<<<<< HEAD

        void LogWarn(string message);

        void LogDebug(string message);

=======
        void LogWarn(string message);
        void LogDebug(string message);
>>>>>>> Added database (and fixed issues)
        void LogError(string message);
    }
}
