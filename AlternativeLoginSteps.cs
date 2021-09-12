using ConsoleApp2.Pagefiles;
using System;
using TechTalk.SpecFlow;

namespace ConsoleApp2.Stepdefinitions
{
    [Binding]
    public class AlternativeLoginSteps
    {
        AlternativeLoginPageFiles Alternative = null;

        [Given(@"Launch Chrome browser and Navigate to Testenvironment")]
        public void GivenLaunchChromeBrowserAndNavigateToTestenvironment()
        {
            Alternative.LaunchChromeBrowserAndNavigateToTestenvironment();
        }

        [When(@"I click login")]
        public void WhenIClickLogin()
        {
            Alternative.ClickLogin();
        }

        [When(@"I click Alternative login")]
        public void WhenIClickAlternativeLogin()
        {
            Alternative.ClickAlternativeLogin();
        }

        [When(@"I enter SSN '(.*)' and PinOne '(.*)'")]
        public void WhenIEnterSSNAndPinOne(string ssn, string pinone)
        {
            Alternative.EnterSSNAndPinOne(ssn, pinone);
        }

        [When(@"I Submit_FirstPin")]
        public void WhenISubmit_FirstPin()
        {
            Alternative.Submit_FirstPin();
            Alternative.Wait();
        }

        [When(@"I enter PinTwo '(.*)'")]
        public void WhenIEnterPinTwo(string pintwo)
        {
            Alternative.EnterPinTwo(pintwo);
        }

        [When(@"I Submit_SecondPin")]
        public void WhenISubmit_SecondPin()
        {
            Alternative.Submit_SecondPin();
           
        }

        [Then(@"I should Log in")]
        public void ThenIShouldLogIn()
        {
            Alternative.ShouldLogIn();
        }

    }
}
