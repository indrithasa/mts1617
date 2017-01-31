using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace seleniumTest
{
    [Binding]
    public class SearchSteps
    {
        private IWebDriver _driver;
        //readonly TestingBotClass _tbClass;

        public SearchSteps()
        {
           // _tbClass = (TestingBotClass)ScenarioContext.Current["_tbClass"];

        }

        [Given(@"Une jam ne faqen e youtube")]
        public void GivenUneJamNeFaqenEYoutube(string profile, string environment)
        {
           // _driver = _tbClass.Init(profile, environment);
            _driver.Navigate().GoToUrl("https://www.youtube.com/");
        }
        
        [When(@"Une kerkoj per ""(.*)""")]
        public void WhenUneKerkojPer(string kerko)
        {
            var query = _driver.FindElement(By.Name("search_query"));
            query.SendKeys(kerko);
            query.Submit();
        }
        
        [Then(@"Une duhet te shikoj rezultate per ""(.*)""")]
        public void ThenUneDuhetTeShikojRezultatePer(string rezultat)
        {
            Thread.Sleep(5000);
            
        }
    }
}
