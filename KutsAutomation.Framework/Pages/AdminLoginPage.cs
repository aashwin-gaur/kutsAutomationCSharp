﻿using KutsAutomation.Framework.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace KutsAutomation.Framework.Pages
{
    /// <summary>
    /// Admin Login Page
    /// </summary>
    public class AdminLoginPage
    {
        private String url = "http://admin-demo.nopcommerce.com/login?ReturnUrl=%2fadmin%2f";

        public bool isAt
        {
            get
            {
                if (WebDriver.driver().Url.ToLower().Equals(url.ToLower())) return true;
                return false;
            }
        }

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement email { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement password { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div/div/div[2]/div[1]/div/form/div[3]/input")]
        public IWebElement loginbutton { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminLoginPage"/> class.
        /// </summary>
        public AdminLoginPage()
        {
            PageFactory.InitElements(WebDriver.driver(), this);
        }

        /// <summary>
        /// Goto the page.
        /// </summary>
        /// <returns></returns>
        public AdminLoginPage gotoPage()
        {
            WebDriver.driver().Navigate().GoToUrl(url);
            return this;
        }

        /// <summary>
        /// Logins the specified email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <returns>this page</returns>
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