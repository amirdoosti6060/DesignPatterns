using Singleton;

Console.WriteLine("Singleton Design Pattern (Creational Design Pattern)");

// Get the singleton instance of the logger
Logger logger = Logger.Instance;

// Log messages
logger.Log("Logging message 1");
logger.Log("Logging message 2");
