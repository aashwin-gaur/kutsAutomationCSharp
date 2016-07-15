using System;
using KutsAutomation.Framework.Driver;
using TechTalk.SpecFlow;
using NUnit.Framework;
using KutsAutomation.Framework.Pages;
using TechTalk.SpecFlow.Assist;
using KutsAutomation.Framework.Steps.FeatureHandlers;
using OpenQA.Selenium.PhantomJS;

namespace KutsAutomation.Framework.Steps
{
    /// <summary>
    /// As a siteadmin steps
    /// </summary>
    [Binding]
    internal class AsASiteAdminSteps : WebDriver
    {

        [Before]
        public void start()
        {
            instantiateDriver();
        }

        [After]
        public void end()
        {
            quitDriver();
        }

        /// <summary>
        /// Givens the i am on the page.
        /// </summary>
        /// <param name="p0">The p0.</param>
        [Given(@"I am on the ""(.*)"" Page")]
        public void GivenIAmOnThePage(string p0)
        {
            Pages.Pages.adminLoginPage.gotoPage();
            Assert.IsTrue(Pages.Pages.adminLoginPage.isAt);
        }

        /// <summary>
        /// Whens the i login with my credentials.
        /// </summary>
        /// <param name="table">The table.</param>
        [When(@"I login with my credentials")]
        public void WhenILoginWithMyCredentials(Table table)
        {
            var cred = table.CreateInstance<Credentials>();
            Pages.Pages.adminLoginPage.login(cred.username, cred.password);            
        }





        /// <summary>
        /// Whens the i click on remember me.
        /// </summary>
        [When(@"I click on RememberMe")]
        public void WhenIClickOnRememberMe()
        {
            Pages.Pages.adminLoginPage.rememberme.Click();
        }
        /// <summary>
        /// Whens the i reopen the browser.
        /// </summary>
        [When(@"I Reopen the browser")]
        public void WhenIReopenTheBrowser()
        {
            getdriver();
        }
        /// <summary>
        /// Thens the i should be taken to the page.
        /// </summary>
        /// <param name="p0">The p0.</param>
        [Then(@"I should be taken to the ""(.*)"" Page")]
        public void ThenIShouldBeTakenToThePage(string p0)
        {
            Assert.IsTrue(Pages.Pages.dashboardPage.isAt);
        }
        /// <summary>
        /// Thens the i should be given an error.
        /// </summary>
        [Then(@"I should be given an error ""(.*)""")]
        public void ThenIShouldBeGivenAnError(String type)
        {
            if(type.Equals("LoginFail"))
                Assert.IsTrue(Pages.Pages.adminLoginPage.loginfail.Displayed);
            if (type.Equals("WrongEmail"))
                Assert.IsTrue(Pages.Pages.adminLoginPage.wrongemail.Displayed);
        }
        /// <summary>
        /// Thens the i close the browser.
        /// </summary>
        [Then(@"I close the browser")]
        public void ThenICloseTheBrowser()
        {
            closeDriver();            
        }

        [Then(@"I logout")]
        public void ThenILogout()
        {
            Pages.Pages.dashboardPage.logout();
        }

        /// <summary>
        /// Thens the should be the value of the email textbox.
        /// </summary>
        /// <param name="email">The expected emailID</param>
        [Then(@"The ""(.*)"" should be the value of the email textbox")]
        public void ThenTheShouldBeTheValueOfTheEmailTextbox(string email)
        {
            Assert.IsTrue(!Pages.Pages.adminLoginPage.email.Text.Equals(email));
        }
    }
}
