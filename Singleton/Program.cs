//ensuring that only one instance of the class is created


using Singleton;
//check to ensure we can't instantiate an instance of the logger
//var logger1 = new CustomLogger();
var logger2 = CustomLogger.Instance;
var logger3 = CustomLogger.Instance;

//check that instances are the same

Console.WriteLine($"Logger 2 and 3 are the same instance? {logger2 == logger3}");
Console.WriteLine($"Logger 2 and Logger instance are the same instance? {logger2 == CustomLogger.Instance}");

// all should be logging through the same instance
logger2.Log("Testing");
CustomLogger.Instance.Log("Testing 123");