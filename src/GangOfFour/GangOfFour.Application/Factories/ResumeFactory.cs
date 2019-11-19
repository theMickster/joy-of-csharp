using System.Collections.Generic;
using GangOfFour.Core.Entities.Pages;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Application.Factories
{
    public class ResumeFactory : DocumentFactory
    {
        public ResumeFactory()
        {
            CreatePages();
        }

        public sealed override void CreatePages()
        {
            Pages = new List<IPage>
            {
                new CoverLetterPage(),
                new SkillsPage(),
                new ExperiencePage(),
                new EducationPage()
            };
        }
    }
}