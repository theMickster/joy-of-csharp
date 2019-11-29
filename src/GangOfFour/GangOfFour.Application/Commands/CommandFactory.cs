using GangOfFour.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GangOfFour.Application.Commands
{
    public class CommandFactory : ICommandFactory
    {

        public T CreateCommand<T>(params object[] args) where T : IAccountTransaction
        {
            var type = typeof(T);

            var transactionCommand = AppDomain.CurrentDomain
                .GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .FirstOrDefault(p => type.IsAssignableFrom(p) && p.IsClass);

            if (transactionCommand == null)
                return default;

            return (T)Activator.CreateInstance(transactionCommand, args);
        }


        public List<string> GetAllAccountCommands()
        {
            return AppDomain.CurrentDomain
                .GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => typeof(IAccountTransaction).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                .Select(x => x.Name).ToList();
        }
    }
}