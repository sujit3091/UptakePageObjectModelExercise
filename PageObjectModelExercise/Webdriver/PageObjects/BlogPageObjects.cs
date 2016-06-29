using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObjectModelExercise.Webdriver.PageObjects
{
    class BlogPageObjects
    {
        public BlogPageObjects()
        {
            PageFactory.InitElements(PropertiesCollections.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@name='s']")]
        public IWebElement TxtSearchBox { get; set; }

        [FindsBy(How = How.Id, Using = "load-more")]
        public IWebElement BtnLoadMorePosts { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@class='submit']")]
        public IWebElement BtnSubmit { get; set; }
    }
}
