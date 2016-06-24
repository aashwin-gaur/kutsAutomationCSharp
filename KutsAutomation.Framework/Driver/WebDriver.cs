using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.PhantomJS;

namespace KutsAutomation.Framework.Driver
{
    internal enum element { id, name, css, xp, link, classname };

    internal class WebDriver
    {
        public static PhantomJSDriver driverinstance = new PhantomJSDriver();

        public static IWebDriver driver()
        {
            if (driverinstance.Equals(null))
            {
                driverinstance = new PhantomJSDriver();
            }
            driverinstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            return driverinstance;
        }
    }
}