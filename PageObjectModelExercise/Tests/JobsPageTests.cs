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
            NavigateToJobsPage();
        }

        [TestFixtureTearDown]
        public void FixtureCleanUp()
        {
            PropertiesCollections.driver.Close();
        }

        [Test]
        public void NavigateToJobsPageTest()
        {
            Assert.IsTrue(_page.HeroHeader.Displayed);
        }
        [Test]
        public void VerifyJobsPageTitle()
        {
            Assert.AreEqual("Join Us | Uptake", PropertiesCollections.driver.Title);
        }
    }
}
