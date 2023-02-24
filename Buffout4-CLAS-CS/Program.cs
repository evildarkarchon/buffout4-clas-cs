// See https://aka.ms/new-console-template for more information
using Ookii.CommandLine;
namespace CLAS;
[ParseOptions(Mode = ParsingMode.LongShort,
    CaseSensitive = true,
    ArgumentNameTransform = NameTransform.DashCase,
    ValueDescriptionTransform = NameTransform.DashCase)]
class Arguments
{
    
}
static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}