using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using ConsoleApp2.Stepdefinitions;

namespace ConsoleApp2.Stepdefinitions
{
    [Binding]
    public class ServicesSteps : ServicesPageFiles
     
    {
        ServicesPageFiles servicepage = null;
        [When(@"I navigate to available services")]
        public void WhenINavigateToAvailableServices()
        {
            servicepage.NavigateToAvailableServices();
        }

        [When(@"I select '(.*)' service and service type '(.*)'")]
        public void WhenISelectServiceAndServiceType(string service, string servicetype)
        {
            servicepage.SelectServiceAndServiceType(service, servicetype);
        }

        [When(@"I activate service, click continue with user,continue with form/service")]
        public void WhenIActivateServiceClickContinueWithUserContinueWithFormService()
        {
            servicepage.ActivateServiceClickContinueWithUserContinueWithFormService();
        }

        [When(@"I fill '(.*)','(.*)','(.*)','(.*)'out page one")]
        public void WhenIFillOutPageOne(string name, string address, string postno, string sted)
        {
            servicepage.FillOutPageOne(name, address, postno, sted); 
        }

        [When(@"I fill out page two")]
        public void WhenIFillOutPageTwo()
        {
            servicepage.FillOutPageTwo();
        }

        [When(@"I click controll skjema")]
        public void WhenIClickControllSkjema()
        {
            servicepage.ClickControllSkjema();
        }

        [When(@"I close popup alert box and click continue to sign and submit form")]
        public void WhenIClosePopupAlertBoxAndClickContinueToSignAndSubmitForm()
        {
            servicepage.ClosePopupAlertBoxAndClickContinueToSignAndSubmitForm();
        }

        [Then(@"I Logout and close browser")]
        public void ThenILogoutandCloseBrowser()
        {
            servicepage.LogoutandCloseBrowser();
        }

    }
}
