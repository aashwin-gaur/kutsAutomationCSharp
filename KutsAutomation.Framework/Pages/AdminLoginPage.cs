
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using KutsAutomation.Framework.Driver;

namespace KutsAutomation.Framework.Pages

{
    public class AdminLoginPage

    {
        String url = "http://admin-demo.nopcommerce.com/login?ReturnUrl=%2fadmin%2f";

        public bool isAt {
            get
            {
                if (GlobalWebDriver.driver.Url.ToString().Equals(url)) return true;
                else return false;
            }
        }
   
        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement email { get; set; }

        [FindsBy(How = How.ClassName, Using = "password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.ClassName, Using = "button-1 login-button")]
        public IWebElement loginbutton { get; set; }



        public AdminLoginPage()
        {
            PageFactory.InitElements(GlobalWebDriver.driver, this);
        }

        public AdminLoginPage gotoPage()
        {
            GlobalWebDriver.driver.Navigate().GoToUrl(url);
            return this;
        }
      public AdminLoginPage login(String email,String password)
        {
            this.email.Clear();
            this.email.SendKeys(email);
            this.Password.Clear();
            this.Password.SendKeys(password);
            loginbutton.Click();
            return this;
        }

    }
}