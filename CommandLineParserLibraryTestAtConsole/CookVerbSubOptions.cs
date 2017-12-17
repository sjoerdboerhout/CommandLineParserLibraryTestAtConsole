using CommandLine;

namespace CommandLineParserLibraryTestAtConsole
{
  class CookVerbSubOptions
  {
    [Option("mins", Required = true)]
    public int CookingMinutes { get; set; }

    [Option("temp")]
    public int CookingTemperature { get; set; }

  }
}
