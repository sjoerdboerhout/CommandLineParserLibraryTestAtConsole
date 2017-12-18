

using System;

namespace CommandLineParserLibraryTestAtConsole
{
  public class Program
  {
    static void Main(string[] args)
    {
      try
      {
        var options = new Options();
        CommandLine.Parser.Default.ParseArgumentsStrict(args, options, OnVerbCommand, OnFail);

        Console.ReadLine();
      }
      catch(Exception e)
      {
        Console.WriteLine(e);
      }
    }

    private static void OnFail()
    {
      Console.WriteLine("Something went wrong...");

    }

    private static void OnVerbCommand(string verbName, object verbSubOptions)
    {
      if( verbSubOptions is SetVerbSubOptions)
      {
        var setSubOptions = (SetVerbSubOptions)verbSubOptions;
      }
      else if(verbSubOptions is WaitVerbSubOptions)
      {
        var waitSubOptions = (WaitVerbSubOptions)verbSubOptions;
      }
    }
  }
}
