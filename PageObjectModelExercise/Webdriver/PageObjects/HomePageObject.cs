using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace PageObjectModelExercise
{
    class HomePageObject
    {
        public HomePageObject()
        {          
            PageFactory.InitElements(PropertiesCollections.driver,this);
        }

        [FindsBy(How = How.LinkText, Using = "Approach")]
        public IWebElement navApproach { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".splash")]
        public IWebElement SplashElement { get; set; }

        

    }
}
