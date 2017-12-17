

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
        CommandLine.Parser.Default.ParseArguments(args, options, OnVerbCommand);

        Console.ReadLine();
      }
      catch(Exception e)
      {
        Console.WriteLine(e);
      }
    }

    private static void OnVerbCommand(string verbName, object verbSubOptions)
    {
      if( verbSubOptions is MixVerbSubOptions)
      {
        var mixSubOptions = (MixVerbSubOptions)verbSubOptions;
      }
      else if(verbSubOptions is CookVerbSubOptions)
      {
        var cookSubOptions = (CookVerbSubOptions)verbSubOptions;
      }

      switch(verbName)
      {
        case "mix":
          var mixSubOptionsX = (MixVerbSubOptions)verbSubOptions;
        break;

        case "cook":
          var cookSubOptionsX = (CookVerbSubOptions)verbSubOptions;
        break;

      }
    }
  }
}
