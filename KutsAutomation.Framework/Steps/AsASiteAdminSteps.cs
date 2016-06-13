﻿using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using KutsAutomation.Framework.Pages;
using TechTalk.SpecFlow.Assist;
using KutsAutomation.Framework.Steps.FeatureHandlers;

namespace KutsAutomation.Framework.Steps
{
    [Binding]
    public class AsASiteAdminSteps
    {
        [Given(@"I am on the ""(.*)"" Page")]
        public void GivenIAmOnThePage(string p0)
        {
            Pages.Pages.adminLoginPage.gotoPage();
            Assert.IsTrue(Pages.Pages.adminLoginPage.isAt);
            
        }
        
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