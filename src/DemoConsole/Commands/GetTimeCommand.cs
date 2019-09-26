using ManyConsole;
using System;

namespace DemoConsole.Commands
{
    public class GetTimeCommand : ConsoleCommand
    {
        public GetTimeCommand()
        {
            this.IsCommand("GetTime", "Returns the current system time.");
        }

        public override int Run(string[] remainingArguments)
        {
            Console.WriteLine(DateTime.UtcNow);

            return 0;
        }
    }
}
