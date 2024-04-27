using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Logger
    {
        private static Logger? instance;
        private static readonly object lockObject = new object();

        private Logger() { }

        public static Logger Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new Logger();
                    }
                    return instance;
                }
            }
        }

        public void Log(string message)
        {
            // Log the message
            Console.WriteLine($"[INFO] {message}");
        }
    }
}
