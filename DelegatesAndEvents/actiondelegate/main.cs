
using System;
using System.IO;

public class FileLogger{
    
    public void Log(string msg)
    {
        File.WriteAllText("file-log.tx",msg);
    }
    
}

public class ConsoleLogger{
    
    public void Log(string msg)
    {
        Console.WriteLine(msg);
    }
}

public class  LogProvider{
   public static Action<string> Logger;
     static LogProvider()
    {
        Logger=new ConsoleLogger().Log;
    }
    
    
}


class HelloWorld {
 public static void Main(string []args) {
      LogProvider.Logger("logging some thing");
      LogProvider.Logger= new FileLogger().Log;
      
      LogProvider.Logger("sample text");
      
    //   FileLogger fileLogger=new FileLogger();
    //   fileLogger.Log("sdhsbdu");
      
      
  }
}