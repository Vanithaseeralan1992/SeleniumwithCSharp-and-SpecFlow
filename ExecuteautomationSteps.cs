using ConsoleApp2.Pagefiles;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ConsoleApp2.Stepdefinitions
{
    [Binding]

    public class ExecuteautomationSteps : ExecuteautomationPageFiles
    {
        ExecuteautomationPageFiles exeobj = new ExecuteautomationPageFiles();

        [Given(@"I navigate to executeautomation")]
        public void GivenINavigateToExecuteautomation()
        {
            exeobj.NavigateToExecuteautomation();              
        }
        
        [When(@"I click execute automation login")]
        public void WhenIClickExecuteAutomationLogin()
        {          
            exeobj.ClickExecuteAutomationLogin();          
        }

        [When(@"Enter username '(.*)' and password '(.*)'")]
        public void WhenEnterUsernameAndPassword(string username, string password)
        {            
            exeobj.EnterUsernameAndPassword(username, password);
        }
        
        [Then(@"I click submit and user is logged in")]
        public void ThenUserIsLoggedIn()
        {            
            exeobj.UserIsLoggedIn();
        }
    }
}
