using System;
using TechTalk.SpecFlow;

namespace KutsAutomation.Framework
{
    [Binding]
    public class AsASiteAdminSteps
    {
        [Given(@"I am on the ""(.*)"" Page")]
        public void GivenIAmOnThePage(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I login with my credentials")]
        public void WhenILoginWithMyCredentials(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on RememberMe")]
        public void WhenIClickOnRememberMe()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I Reopen the browser")]
        public void WhenIReopenTheBrowser()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be taken to the ""(.*)"" Page")]
        public void ThenIShouldBeTakenToThePage(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be given an error")]
        public void ThenIShouldBeGivenAnError()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I close the browser")]
        public void ThenICloseTheBrowser()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The ""(.*)"" should be the value of the email textbox")]
        public void ThenTheShouldBeTheValueOfTheEmailTextbox(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
