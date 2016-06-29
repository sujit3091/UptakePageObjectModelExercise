using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using PageObjectModelExercise.Webdriver.PageObjects;

namespace PageObjectModelExercise.Tests
{
    class JobsPageTests :PageTestsBase
    {
        private JobsPageObjects _page;

        [TestFixtureSetUp]
        public void FixtureSetUp()
        {
            PropertiesCollections.driver = new FirefoxDriver();
            _page = new JobsPageObjects();
            NavigateToBlogPage();
        }

        [TestFixtureTearDown]
        public void FixtureCleanUp()
        {
            PropertiesCollections.driver.Close();
        }

        [Test]
        public void NavigateToJobsPageTest()
        {
            var page = new JobsPageObjects();
            NavigateToJobsPage();
            Assert.IsTrue(page.HeroHeader.Displayed);
        }
    }
}
