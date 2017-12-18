using CommandLine;

namespace CommandLineParserLibraryTestAtConsole
{
  class SetVerbSubOptions
  {
    [Option('l', "load", 
      HelpText = "The load for the bicycle")]


      //MutuallyExclusiveSet = "abc"]
    public int Load {get; set;}

    [Option('r',"rpm")]
    public int Rpm { get; set; }

    [Option] //[Option('v')]
    public bool Verbose { get; set; }
  }
}
