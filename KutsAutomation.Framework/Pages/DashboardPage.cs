using KutsAutomation.Framework.Driver;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace KutsAutomation.Framework.Pages
{
    internal class DashboardPage
    {
        private String url = "http://admin-demo.nopcommerce.com/admin/";

        /// <summary>
        /// Gets a value indicating whether this instance is at this page.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is at the page; otherwise, <c>false</c>.
        /// </value>
        public bool isAt
        {
            get
            {
                if (WebDriver.driver().Url.ToLower().Equals(url.ToLower())) return true;

                return false;
            }
        }

        public DashboardPage()
        {
            PageFactory.InitElements(WebDriver.driver(), this);
        }

        /// <summary>
        /// Goto the page.
        /// </summary>
        /// <returns></returns>
        public DashboardPage gotoPage()
        {
            WebDriver.driver().Navigate().GoToUrl(url);
            return this;
        }
    }
}