using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace mdc.Api.Utils
{
    public class EFLoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName) => new EFLogger(categoryName);
        public void Dispose() { }
    }

    public class EFLogger : ILogger
    {
        private readonly string categoryName;

        private string logPath = AppContext.BaseDirectory + "log\\";

        public EFLogger(string categoryName)
        {
            this.categoryName = categoryName;
            try
            {
                if (Directory.Exists(logPath))
                {
                    string[] logs = Directory.GetFiles(logPath);
                    if (logs.Length == 0)
                    {
                        return;
                    }
                    FileInfo fi = new FileInfo(logs[0]);
                    if (fi.LastWriteTime.Date != DateTime.Now.Date)
                    {
                        Directory.Delete(logPath, true);
                    }
                }
                if (!Directory.Exists(logPath))
                {
                    Directory.CreateDirectory(logPath);
                }
            }
            catch (Exception ex)
            {

            }
        }

        public bool IsEnabled(LogLevel logLevel) => true;

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            DateTime now = DateTime.Now;
            //ef core执行数据库查询时的categoryName为Microsoft.EntityFrameworkCore.Database.Command,日志级别为Information
            if (categoryName == "Microsoft.EntityFrameworkCore.Database.Command")
            {
                try
                {
                    var logContent = string.Format("[{0}]{2}{1}{2}{2}", now.ToString("yyyy-MM-dd HH:mm:ss"), formatter(state, exception), Environment.NewLine);
                    if (logLevel == LogLevel.Warning)
                    {
                        File.AppendAllText(Path.Combine(logPath, "EF_Error.log"), logContent);
                    }
                    else
                    {
                        File.AppendAllText(Path.Combine(logPath, $"EF_Sql_{DateTime.Now.ToString("HH")}.log"), logContent);
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        public IDisposable BeginScope<TState>(TState state) => null;
    }
}
