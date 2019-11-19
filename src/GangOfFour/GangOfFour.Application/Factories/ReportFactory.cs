using System.Collections.Generic;
using GangOfFour.Core.Entities.Pages;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Application.Factories
{
    public class ReportFactory : DocumentFactory
    {
        public ReportFactory()
        {
            CreatePages();
        }

        public sealed override void CreatePages()
        {
            Pages = new List<IPage>
            {
                new IntroductionPage(),
                new ResultsPage(),
                new ConclusionPage(),
                new SummaryPage(),
                new BibliographyPage()
            };
        }
    }
}