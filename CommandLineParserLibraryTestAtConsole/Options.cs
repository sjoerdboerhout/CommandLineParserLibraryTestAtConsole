using CommandLine;
using CommandLine.Text;
using System.Collections.Generic;

namespace CommandLineParserLibraryTestAtConsole
{
  class Options
  {
    [VerbOption("set")]
    public SetVerbSubOptions SetVerb { get; set; }


    [VerbOption("wait")]
    public WaitVerbSubOptions WaitVerb { get; set; }

    [ParserState]
    public IParserState LastParserState { get; set; }

    // Remainder omitted
    [HelpVerbOption]
    public string GetUsage(string verb)
    {
      return HelpText.AutoBuild(this, verb);
    }
  }
}
