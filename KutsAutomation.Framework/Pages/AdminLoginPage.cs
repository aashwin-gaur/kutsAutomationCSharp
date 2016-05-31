﻿
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
        String url = "";

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


    }
}