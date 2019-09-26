using System;
using ManyConsole;

namespace DemoConsole.Commands
{
    public class EchoCommand : ConsoleCommand
    {
        public string ToEcho { get; set; }

        public EchoCommand()
        {
            IsCommand("Echo", "Returns text back to you...");

            HasRequiredOption("t=", "The text to echo...", t => ToEcho = t);

        }

        public override int Run(string[] remainingArguments)
        {
            Console.Out.WriteLine(ToEcho);

            return 0;
        }
    }
}
