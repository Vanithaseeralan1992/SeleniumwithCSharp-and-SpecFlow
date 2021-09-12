using TechTalk.SpecFlow;
using ConsoleApp2.Pagefiles;

namespace ConsoleApp2.Stepdefinitions
{
    [Binding]
   public class OrangeHRMSteps
    {
        ORangeHRMPageFiles HRMobject = new ORangeHRMPageFiles();
        [Given(@"Launch chrome browser")]
        public void GivenLaunchChromeBrowser()
        {
            HRMobject.ChromeBrowser();
        }

        [Given(@"Navigate to OrgangeHRM Page")]
        public void GivenNavigateToOrgangeHRMPage()
        {
            HRMobject.OrgangeHRMPage();
        }

        [When(@"I click Contactsales button")]
        public void WhenIClickContactsalesButton()
        {
            HRMobject.ClickContactsalesButton();
        }
       
        [When(@"Fill the fields '(.*)' , '(.*)' and '(.*)'")]
        public void WhenFillTheFieldsAnd(string firstname, string secondname, string companyname)
        {
            HRMobject.FillTheFields(firstname, secondname, companyname);
        }

        [When(@"Select The Element for number of employees group 16 to 20")]
        public void WhenSelectTheElementForNumberOfEmployeesGroup()
        {
            HRMobject.NumberOfEmployeesGroup();
        }

        [When(@"Fill '(.*)', '(.*)' and '(.*)' details")]
        public void WhenFillAndDetails(string jobtitle, string contactno, string email)
        {
            HRMobject.Fillinfoof(jobtitle, contactno, email);
        }

        [When(@"Select Country Norway and fill comment section")]
        public void WhenSelectCountryNorwayAndFillCommentSection()
        {
            HRMobject.CountryandComment();
        }

        [Then(@"Scroll down and submit")]
        public void ThenScrollDownAndSubmit()
        {
            HRMobject.ScrollDownAndSubmit();
        }

    }
}
