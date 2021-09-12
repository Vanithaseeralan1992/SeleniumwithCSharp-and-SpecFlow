using ConsoleApp2.Pagefiles;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace ConsoleApp2.Stepdefinitions
{
    [Binding]
    public class BankIDPåMobilSteps
    {

        BankIDPåMobilPageFiles Bankidobject = new BankIDPåMobilPageFiles();
        [Given(@"Launch Chrome browser and Navigate to Altinn page")]
        public void GivenLaunchChromeBrowserAndNavigateToAltinnPage()
        {

            Bankidobject.LaunchChromeBrowserAndNavigateToAltinnPage();
        }

        [When(@"I click Login")]
        public void WhenIClickLogin()
        {
            Bankidobject.ClickLogin();
        }

        [When(@"I click BankIdPåmobil")]
        public void WhenIClickBankIdPamobil()
        {
            Bankidobject.ClickBankIdPamobil();       
        }

        [When(@"I enter Mobno '(.*)' and DOB '(.*)'")]
        public void WhenIEnterMobnoAndDOB(string mobileno, string dob)
        {
            Bankidobject.EnterMobnoAndDOB(mobileno, dob);
        }

        [Then(@"I should log in")]
        public void ThenIShouldLogIn()
        {
            Bankidobject.ShouldLogIn();
           // Assert.Pass("User is logged in");
        }

        [Then(@"I click Profile page")]
        public void ThenIClickProfilePage()
        {
            Bankidobject.Wait();
            Bankidobject.ClickProfilePage();
        }

        [Then(@"I go to OthersWithRights panel")]
        public void ThenIGoToOthersWithRightsPanel()
        {
            Bankidobject.Wait();
            Bankidobject.GoToOthersWithRightsPanel();
        }

        [Then(@"I Click AddpersonorORG button")]
        public void ThenIClickAddpersonorORGButton()
        {
            Bankidobject.ClickAddpersonorORGButton();
        }

        [Then(@"I Enter '(.*)' and '(.*)'")]
        public void ThenIEnterAnd(string ssn, string lastname)
        {
            Bankidobject.Wait();
            Bankidobject.EnterAnd(ssn, lastname);
        }

        [Then(@"I click Next")]
        public void ThenIClickNext()
        {
            Bankidobject.ClickNext();
        }

        [When(@"I click ProvidAccess button")]
        public void WhenIClickProvidAccessButton()
        {
            Bankidobject.Wait();
            Bankidobject.ClickProvidAccessButton();
        }

        [When(@"I select service'(.*)'")]
        public void WhenISelectService(string service)
        {
            Bankidobject.SelectService(service);
        }

        [When(@"I submit '(.*)' button")]
        public void WhenISubmitButton(string service)
        {
            Bankidobject.Wait();
            Bankidobject.SubmitButton(service);  
        }

        [When(@"I click submit button")]
        public void WhenIClickSubmitButton()
        {
            Bankidobject.Wait();
            Bankidobject.Scrolldown();
            Bankidobject.ClickSubmitButton();
            Bankidobject.Wait();
        }

        [When(@"I click Give rights button")]
        public void WhenIClickGiveRightsButton()
        {
            Bankidobject.ClickGiveRightsButton();
        }

        [Then(@"I click done button")]
        public void ThenIClickDoneButton()
        {
            Bankidobject.ClickDoneButton();
        }
        [Then(@"I got to Myrequests panel")]
        public void ThenIGotToMyrequestsPanel()
        {
            Bankidobject.GotToMyrequestsPanel();
        }

        [Then(@"I click create new request button")]
        public void ThenIClickCreateNewRequestButton()
        {
            Bankidobject.ClickCreateNewRequestButton();
        }

        [Then(@"I select user '(.*)' in search list")]
        public void ThenISelectUserInSearchList(string user)
        {
            Bankidobject.SelectUserInSearchList(user);
        }

        [Then(@"I select service '(.*)' for request and add service")]
        public void ThenISelectServiceForRequestAndAddService(string service)
        {
            Bankidobject.SelectServiceForRequestAndAddService(service);
        }

        [Then(@"I click next and I enter email")]
        public void ThenIClickNextAndIEnterEmail()
        {
            Bankidobject.ClickNextAndIEnterEmail();
        }

        [Then(@"I send request and click done")]
        public void ThenISendRequestAndClickDone()
        {
            Bankidobject.SendRequestAndClickDone();
        }







    }
}
