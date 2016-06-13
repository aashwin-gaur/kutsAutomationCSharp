using KutsAutomation.Framework.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace KutsAutomation.Framework.Pages
{
    public class AdminLoginPage
    {
        private String url = "http://admin-demo.nopcommerce.com/login?ReturnUrl=%2fadmin%2f";

        public bool isAt
        {
            get
            {
                if (WebDriver.driver().Url.Equals(url)) return true;
                return false;
            }
        }

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement email { get; set; }

        [FindsBy(How = How.ClassName, Using = "password")]
        public IWebElement password { get; set; }

        [FindsBy(How = How.ClassName, Using = "button-1 login-button")]
        public IWebElement loginbutton { get; set; }

        public AdminLoginPage()
        {
            PageFactory.InitElements(WebDriver.driver(), this);
            Console.WriteLine("hi");
        }

        public AdminLoginPage gotoPage()
        {
            WebDriver.driver().Navigate().GoToUrl(url);
            return this;
        }

        public AdminLoginPage login(String email, String password)
        {
            if (!isAt)
            {
                gotoPage();
            }
            this.email.Clear();
            this.email.SendKeys(email);
            this.password.Clear();
            this.password.SendKeys(password);
            loginbutton.Click();
            return this;
        }
    }
}