using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using PageObjectModelExercise.Webdriver.PageObjects;

namespace PageObjectModelExercise.Tests
{
    class BlogPageTests : PageTestsBase
    {
        private BlogPageObjects _page;

        [TestFixtureSetUp]
        public void FixtureSetUp()
        {
            PropertiesCollections.driver = new FirefoxDriver();
            _page = new BlogPageObjects();
            NavigateToBlogPage();
        }

        [TestFixtureTearDown]
        public void FixtureCleanUp()
        {
            PropertiesCollections.driver.Close();
        }

        [Test]
        public void NavigateToAndVerifyBlogPageTest()
        {
            Assert.IsTrue(_page.BtnLoadMorePosts.Displayed);
            _page.TxtSearchBox.SendKeys("A note from brad");
            _page.BtnSubmit.Click();

            //TO DO: There should be a better way to do this
            Assert.IsTrue(PropertiesCollections.driver.FindElement(By.CssSelector("a[href='http://uptake.com/a-note-from-brad/']")).Displayed);
        }
        
        
    }
}
