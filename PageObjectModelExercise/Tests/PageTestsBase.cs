using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageObjectModelExercise.Properties;

namespace PageObjectModelExercise.Tests
{
    public class PageTestsBase
    {
        public static void NavigateToHomePage()
        {
            var homeUrl = new Uri(Settings.Default.HomeUrl);
            PropertiesCollections.driver.Navigate().GoToUrl(homeUrl.ToString());
        }

        public static void NavigateToBlogPage()
        {
            var homeUrl = new Uri(new Uri(Settings.Default.HomeUrl), "ourblog/");
            PropertiesCollections.driver.Navigate().GoToUrl(homeUrl.ToString());
        }

        public static void NavigateToJobsPage()
        {
            var homeUrl = new Uri(new Uri(Settings.Default.HomeUrl), "jobs/");
            PropertiesCollections.driver.Navigate().GoToUrl(homeUrl.ToString());
        }
    }
}
