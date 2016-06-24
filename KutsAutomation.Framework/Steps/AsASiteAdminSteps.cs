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
    public class AsASiteAdminSteps
    {

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
        
        [When(@"I click on RememberMe")]
        public void WhenIClickOnRememberMe()
        {
            
        }
        
        [When(@"I Reopen the browser")]
        public void WhenIReopenTheBrowser()
        {
            
        }
        
        [Then(@"I should be taken to the ""(.*)"" Page")]
        public void ThenIShouldBeTakenToThePage(string p0)
        {
            Assert.IsTrue(Pages.Pages.dashboardPage.isAt);
        }
        
        [Then(@"I should be given an error")]
        public void ThenIShouldBeGivenAnError()
        {
            
        }
        
        [Then(@"I close the browser")]
        public void ThenICloseTheBrowser()
        {
            
        }
        
        [Then(@"The ""(.*)"" should be the value of the email textbox")]
        public void ThenTheShouldBeTheValueOfTheEmailTextbox(string p0)
        {
            
        }
    }
}
