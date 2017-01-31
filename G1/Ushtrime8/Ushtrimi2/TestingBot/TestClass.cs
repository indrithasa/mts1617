using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using System.Collections.Specialized;
using System.Configuration;

namespace TestingBot
{
    [Binding]
    public sealed class Testing
    {
        private TestClass tbClass;
        private string[] tags;

        [BeforeScenario]
        public void BeforeScenario()
        {
            tbClass = new TestClass(ScenarioContext.Current);
            ScenarioContext.Current["tbClass"] = tbClass;
        }
        [AfterScenario]
        public void AfterScenario()
        {
            tbClass.Cleanup();
        }
    }
    public  class TestClass
    {
        private IWebDriver driver;
        private string profile;
        private string environment;
        private ScenarioContext context;

  public TestClass(ScenarioContext context)
  {
    this.context = context;
  }

  public IWebDriver Init(string profile, string environment)
  {
    NameValueCollection caps = ConfigurationManager.GetSection("capabilities/" + profile) as NameValueCollection;
    NameValueCollection settings = ConfigurationManager.GetSection("environments/" + environment) as NameValueCollection;

    DesiredCapabilities capability = new DesiredCapabilities();

    foreach (string key in caps.AllKeys)
    {
      capability.SetCapability(key, caps[key]);
    }

    foreach (string key in settings.AllKeys)
    {
      capability.SetCapability(key, settings[key]);
    }

    string key1 = Environment.GetEnvironmentVariable("TB_KEY");
    if (key1 == null)
    {
      key1 = ConfigurationManager.AppSettings.Get("key");
    }

    String secret = Environment.GetEnvironmentVariable("TB_SECRET");
    if (secret == null)
    {
      secret = ConfigurationManager.AppSettings.Get("secret");
    }

    capability.SetCapability("key", key1);
    capability.SetCapability("secret", secret);

    driver = new RemoteWebDriver(new Uri("http://" + ConfigurationManager.AppSettings.Get("server") + "/wd/hub/"), capability);
    return driver;
    }
    
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
