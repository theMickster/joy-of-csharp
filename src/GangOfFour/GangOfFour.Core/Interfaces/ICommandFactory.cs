using System.Collections.Generic;

namespace GangOfFour.Core.Interfaces
{
    public interface ICommandFactory
    {
        T CreateCommand<T>(params object[] args) where T : IAccountTransaction;

        List<string> GetAllAccountCommands();
    }
}