using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace KutsAutomation.Framework.Driver
{
    internal enum element { id, name, css, xp, link, classname };

    internal class WebDriver
    {
        public static IWebDriver driverinstance = new PhantomJSDriver();

        public static IWebDriver driver()
        {
            if (driverinstance.Equals(null))
            {
                driverinstance = new PhantomJSDriver(); 
            }
            
            return driverinstance;
        }
    }
}