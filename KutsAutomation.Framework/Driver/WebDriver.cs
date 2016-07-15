using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.PhantomJS;

namespace KutsAutomation.Framework.Driver
{
    internal enum element { id, name, css, xp, link, classname };

    internal class WebDriver
    {

        private static IWebDriver driverinstance = new PhantomJSDriver();


        public static IWebDriver instantiateDriver()
        {
            if (driverinstance.Equals(null))
            {
                driverinstance = new PhantomJSDriver();
            }
            if (driverinstance.WindowHandles.Count == 0)
            {
                Console.WriteLine("0 Windows!");
                driverinstance = new PhantomJSDriver();
            }
            driverinstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            return driverinstance;
        }


        public static IWebDriver getdriver()
        {
            
            return driverinstance;
        }



        public static void closeDriver()
        {
            driverinstance.Close();
        }

        public static void quitDriver()
        {
            driverinstance.Quit();
        }

    }
}