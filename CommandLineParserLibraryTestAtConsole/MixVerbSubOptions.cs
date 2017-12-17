using CommandLine;

namespace CommandLineParserLibraryTestAtConsole
{
  class MixVerbSubOptions
  {
    [Option('m', "mins", HelpText = "The number of minutes to cook")]
    public int Minutes {get; set;}

    [Option("speed")]
    public int Speed { get; set; }

    [Option] //[Option('v')]
    public bool Verbose { get; set; }
  }
}
