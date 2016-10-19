using System;
using System.Collections.Generic;

namespace FactoryRealWorld
{
    internal static class Program
    {
        private static void Main()
        {
            var documents = new Document[2];
            documents[0] = new Resume();
            documents[1] = new Report();
            foreach (var document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (var page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }
            Console.ReadKey();
        }
    }

    internal class Report : Document
    {
        protected override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }

    internal class ExperiencePage : Page
    {
    }

    internal class Resume : Document
    {
        protected override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }

    internal class ConclusionPage : Page
    {
    }

    abstract class Page
    {
    }

    internal class SkillsPage : Page
    {
    }

    internal class SkillsExperiencePage : Page
    {
    }

    internal class IntroductionPage : Page
    {
    }

    internal class ResultsPage : Page
    {
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class SummaryPage : Page
    {
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class BibliographyPage : Page
    {
    }

    internal class EducationPage : Page
    {
    }
    /// <summary>
    /// Creator
    /// </summary>
    internal abstract class Document
    {
        protected Document()
        {
            CreatePages();
        }

        protected abstract void CreatePages();

        public IList<Page> Pages { get; } = new List<Page>();
    }
  
}


