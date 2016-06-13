using KutsAutomation.Framework.Driver;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace KutsAutomation.Framework.Pages
{
    internal class DashboardPage
    {
        private String url = "http://admin-demo.nopcommerce.com/admin/";

        public bool isAt
        {
            get
            {
                if (WebDriver.driver().Url.Equals(url)) return true;

                return false;
            }
        }

        public DashboardPage()
        {
            PageFactory.InitElements(WebDriver.driver(), this);
        }

        public DashboardPage gotoPage()
        {
            WebDriver.driver().Navigate().GoToUrl(url);
            return this;
        }
    }
}