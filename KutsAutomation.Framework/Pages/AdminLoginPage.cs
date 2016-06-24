using KutsAutomation.Framework.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace KutsAutomation.Framework.Pages
{
    /// <summary>
<<<<<<< HEAD
    /// 
=======
    /// Admin Login Page
>>>>>>> 3c1fa333f425fcf068911ca58754a5eaf0fabfc2
    /// </summary>
    public class AdminLoginPage
    {
        private String url = "http://admin-demo.nopcommerce.com/login?ReturnUrl=%2fadmin%2f";

        /// <summary>
        /// Gets a value indicating whether this instance is at.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is at; otherwise, <c>false</c>.
        /// </value>
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
<<<<<<< HEAD
        
        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement password { get; set; }

        [FindsBy(How = How.CssSelector, Using = "html body div.master-wrapper-page div.master-wrapper-content div.master-column-wrapper div.center-1 div.page.login-page div.page-body div.customer-blocks div.returning-wrapper.fieldset form div.buttons input.button-1.login-button")]
        public IWebElement loginbutton { get; set; }


=======

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement password { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div/div/div[2]/div[1]/div/form/div[3]/input")]
        public IWebElement loginbutton { get; set; }

>>>>>>> 3c1fa333f425fcf068911ca58754a5eaf0fabfc2
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminLoginPage"/> class.
        /// </summary>
        public AdminLoginPage()
        {
            PageFactory.InitElements(WebDriver.driver(), this);
        }
<<<<<<< HEAD
        /// <summary>
        /// Gotoes the page.
=======

        /// <summary>
        /// Goto the page.
>>>>>>> 3c1fa333f425fcf068911ca58754a5eaf0fabfc2
        /// </summary>
        /// <returns></returns>
        public AdminLoginPage gotoPage()
        {
            Console.WriteLine("start url");
            WebDriver.driver().Navigate().GoToUrl(url);
            Console.WriteLine("finish url");
            return this;
        }

        /// <summary>
        /// Logins the specified email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
<<<<<<< HEAD
        /// <returns></returns>
=======
        /// <returns>this page</returns>
>>>>>>> 3c1fa333f425fcf068911ca58754a5eaf0fabfc2
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