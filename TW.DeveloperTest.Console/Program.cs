using System;
using System.Diagnostics;
using System.Threading;
using TW.DeveloperTest.Contracts;

namespace TW.DeveloperTest.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Having limited time to do these without using the internet as a source on how to impliment a logger, this is what i came up with. Hindsight, I feel that even though
            //it was asked of us not to impliment an existing logger, it might be within the realm and scope to have done some research to find out what internal logging functions
            //have been delivered by microsoft. For example, according the following link https://learn.microsoft.com/en-us/dotnet/core/extensions/custom-logging-provider
            //I could have used the ILogger interface by Microsoft. Again, may or may not fall inside the request of not using someones else's work. This would also have implimentations for
            //LogLevel which is another escential part of the project. This would have dymanstically reduced hte time I needed to trial and error my way through this project.
            //This concludes the work I have done so far because I feel that at this point I would have the need to rewrite everything. I WOULD consider using the ILogger and the LogLevel
            //class in my next deminstration but again, that is hindesight as i did not wish to google for an answer but rather show the process of how I had come to setup and try to solve this 
            //issue locally and on my own using only my experience. That being said, I'm not happy at all with how my work turned out as there are many issues that will arise using the 
            //current structure. Thanks for reading this if you have ahead of time.

            bool run = true;
            IWorker worker = Ioc.Resolve<IWorker>();
            HeadLogger logger = new HeadLogger();

            do
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();

                    if (key.Modifiers.HasFlag(ConsoleModifiers.Control)
                        && key.Key == ConsoleKey.X)
                    {
                        run = false;
                    }
                }

                try
                {
                    var result = worker.GetResult();

                    //TODO replace with logging library
                    var debugger = new Contracts.Logger.Debug();
                    debugger.Messages.Add(result);

                    logger.AddLog(debugger);
                    Console.WriteLine($"output - {result}");
                }
                catch (Exception e)
                {
                    //TODO replace with logging library
                    Console.WriteLine($"error - {e.Message}");
                }
                
                Thread.Sleep(500);
            } while (run);
        }
            
    }

}
