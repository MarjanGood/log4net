using log4net;
using log4net.Config;
using System;
using System.IO;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {

            // Load configuration
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

           
            // Log some things
            log.Info("Hello logging world!");
            Console.WriteLine("Hello World2!");
            log.Error("Error!");
            log.Warn("Warn!");
        }
    }
}
