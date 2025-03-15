using Singleton;

var logger = Logger.GetInstance();
var logger2 = Logger.GetInstance();

Console.WriteLine(ReferenceEquals(logger, logger2));