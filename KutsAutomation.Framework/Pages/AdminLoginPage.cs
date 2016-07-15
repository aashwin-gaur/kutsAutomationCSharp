using KutsAutomation.Framework.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using NUnit.Framework;

namespace KutsAutomation.Framework.Pages
{

    /// <summary>
    /// 
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
                if (WebDriver.getdriver().Url.ToLower().Equals(url.ToLower())) return true;
                return false;
            }
        }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement email { get; set; }
        
        
        
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement password { get; set; }

        /// <summary>
        /// Gets or sets the rememberme.
        /// </summary>
        /// <value>
        /// The rememberme.
        /// </value>
        [FindsBy(How=How.Id, Using = "RememberMe")]
        public IWebElement rememberme { get; set; }



        /// <summary>
        /// Gets or sets the loginbutton.
        /// </summary>
        /// <value>
        /// The loginbutton.
        /// </value>
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div/div/div[2]/div[1]/div/form/div[3]/input")]
        public IWebElement loginbutton { get; set; }

      
        /// <summary>
        /// Gets or sets the verifyemail.
        /// </summary>
        /// <value>
        /// The verifyemail.
        /// </value>
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div/div/div[2]/div[1]/div/form/div[2]/div[1]/span/span")]
        public IWebElement verifyemail { get; set; }
        

        /// <summary>
        /// Gets or sets the errormsg.
        /// </summary>
        /// <value>
        /// The errormsg.
        /// </value>
        [FindsBy(How = How.XPath,Using = "/html/body/div/div/div/div/div/div[2]/div[1]/div/form/div[2]/div[1]/span/span")]
            public IWebElement wrongemail { get; set; }

        /// <summary>
        /// Gets or sets the loginfail.
        /// </summary>
        /// <value>
        /// The loginfail.
        /// </value>
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div/div/div[2]/div[1]/div/form/div[2]/div/span")]
        public IWebElement loginfail { get; set; }

        
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminLoginPage"/> class.
        /// </summary>
        public AdminLoginPage()
        {
            PageFactory.InitElements(WebDriver.getdriver(), this);
        }

        /// <summary>
        /// Gotoes the page.
        /// </summary>
        /// <returns></returns>
        public AdminLoginPage gotoPage()
        {            
            WebDriver.getdriver().Navigate().GoToUrl(url);
            return this;
        }

        /// <summary>
        /// Logins the specified email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>

        /// <returns></returns>

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