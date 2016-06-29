using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using PageObjectModelExercise.Properties;

namespace PageObjectModelExercise.Tests
{
    
    public class HomePageTests : PageTestsBase
    {
        private HomePageObject _page;
        
        [TestFixtureSetUp]       
        public void FixtureSetUp()
        {
            PropertiesCollections.driver = new FirefoxDriver();           
            _page = new HomePageObject();   
        }

        [TestFixtureTearDown]
        public void FixtureCleanUp()
        {
            PropertiesCollections.driver.Close();
        }

        [SetUp]
        public void TestSetup()
        {
            NavigateToHomePage();
        }

        [Test]
        public void VerifyHomePageElementsTest()
        {         
            Assert.IsTrue(_page.SplashElement.Displayed);
            _page.navApproach.Click();
            Assert.AreEqual(PropertiesCollections.driver.Url, Settings.Default.ApproachUrl);
        }

        [Test]
        public void NavigateToHomePageTest()
        {
            Assert.AreEqual(PropertiesCollections.driver.Url, Settings.Default.HomeUrl);
        }
    }
}
