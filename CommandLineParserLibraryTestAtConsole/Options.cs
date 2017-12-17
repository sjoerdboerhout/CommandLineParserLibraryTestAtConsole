using CommandLine;
using CommandLine.Text;
using System.Collections.Generic;

namespace CommandLineParserLibraryTestAtConsole
{
  class Options
  {
    [VerbOption("mix")]
    public MixVerbSubOptions MixVerb { get; set; }


    [VerbOption("cook")]
    public CookVerbSubOptions CookVerb { get; set; }


    // Remainder omitted
    [HelpVerbOption]
    public string GetUsage(string verb)
    {
      return HelpText.AutoBuild(this, verb);
    }
  }
}
