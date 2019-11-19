using System;
using GangOfFour.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GangOfFour.Application.Factories
{
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    public abstract class DocumentFactory: IDocumentFactory
    {
        protected DocumentFactory()
        {
        }

        public List<IPage> Pages { get; set; }

        public abstract void CreatePages();

        public string GetDetails()
        {
            return Pages.Aggregate(string.Empty, (current, page) => current + Environment.NewLine + $" {page.GetType().Name}");
        }
    }
}