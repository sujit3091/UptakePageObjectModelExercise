using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObjectModelExercise.Webdriver.PageObjects
{
    class JobsPageObjects
    {
        public JobsPageObjects()
        {
            PageFactory.InitElements(PropertiesCollections.driver, this);
        }
        [FindsBy(How = How.Id, Using = "hero")]
        public IWebElement HeroHeader { get; set; }
    }
}
