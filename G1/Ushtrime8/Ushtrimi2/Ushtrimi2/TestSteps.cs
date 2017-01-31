using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingBot;
using System.Configuration;

namespace Ushtrimi2
{
    [Binding]
    public class TestSteps
    {
        private IWebDriver _driver;
        readonly TestClass _tbClass;
        private string environment;
        private string profile;


        public TestSteps()
        {
            _tbClass = (TestClass)ScenarioContext.Current["_tbClass"];
        }
        [Given(@"Une jam ne faqen e youtube")]
        public void GivenUneJamNeFaqenEYoutube()
        {
            
         
            _driver = _tbClass.Init(profile,environment);
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
            Assert.AreEqual(_driver.Title, rezultat);
        }
    }
}
