using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ConsoleApp2.Pagefiles
{
    public class BankIDPåMobilPageFiles 
    {
        public string AltinnUrl => "https://www.altinn.no/";
        public string ClcikLogin => "//button[@type='button' and @class='a-btn a-btn-border']";
        public string BaniIDmobil => "BankIDMobil";
        public string Mobileno => "idporten.input.CONTACTINFO_MOBILE";
        public string DOB => "idporten.input.BIRTHDATE";
        public string NextButton => "nextbtn";
        public int delay_time => 10;
        public string ProfileLink => "//span[contains(text(),'profil')]";
        public string Otherswithrightspanel => "//body/div[@id='content']/div[2]/div[1]/div[1]/div[1]/div[3]/div[1]/a[1]/div[1]";
        public string AddnewpersonorORG => "//button[@type='button' and @class='a-btn a-btn-action a-fullWidthBtn']";
        public string AddSSN => "NewRightHolder.NewRightHolderPerson.SsnUsername";
        public string AddSurname => "NewRightHolder.NewRightHolderPerson.Surname";
        public string SubmitAddperson => "submitAddNewPerson";
        public string AccessButton => "//button[@class='a-btn a-btn-action']";
        public string DelegateserviceName => "delegation-request-service-search-input";
        public string SubmitSelectedService=> "submitServiceSelectionForDelegationRequest";
        public string Email => "email";
        public string GiverightsBtn => "CreateDelegationRequestbtn";
        //public string ServiceButton => "//button[@class='a-btn a-btn-icon a-btn-overlay-right a-vertical-align px-1 addBtn']";
        public string MyrequestsPanel => "//body/div[@id='content']/div[2]/div[1]/div[1]/div[1]/div[4]/div[1]/a[1]/div[1]";
        public string CreatnewRequestBtn => "//button[@class='a-btn a-btn-action a-fullWidthBtn mt-2 mt-sm-3']";
        public string Searchbox => "offeredBySearchInput";
        public string SearchPerson => "//li[@class='a-list-parentRightHolder' and @data-search-name='sveinung alsvik']";
        public string RequestSearchinput => "delegation-request-service-search-input";
        public string Addservicetorequest => "a-btn a-btn-icon a-btn-overlay-right a-vertical-align px-1 addBtn";
        public string SubmitDelegationRequest => "submitServiceSelectionForDelegationRequest";
        public string RequestEmail => "email";
        public string SendRequestBtn => "CreateDelegationRequestbtn";
        public string kvitteringrequestBtn => "//button[@class='a-btn a-btn-success mr-1']";

        IWebDriver driver = new ChromeDriver();
        internal void LaunchChromeBrowserAndNavigateToAltinnPage()
        {
            driver.Navigate().GoToUrl(AltinnUrl);
            driver.Manage().Window.Maximize();
        }
        internal void ClickLogin()
        {
            driver.FindElement(By.XPath(ClcikLogin)).Click();
        }
        internal void ClickBankIdPamobil()
        {
            driver.FindElement(By.Id(BaniIDmobil)).Click();
        }
        internal void EnterMobnoAndDOB(string mobileno,string dob)
        {
            driver.FindElement(By.Id(Mobileno)).SendKeys(mobileno);
            driver.FindElement(By.Id(DOB)).SendKeys(dob);
        }
        internal void ShouldLogIn()
        {
           
            driver.FindElement(By.Id(NextButton)).Click();
           // Assert.Pass("Passed");
        }

        internal void Wait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(delay_time);
        }

       

        internal void ClickProfilePage()
        {
            driver.FindElement(By.XPath(ProfileLink)).Click();
        }
        internal void GoToOthersWithRightsPanel()
        {   
            driver.FindElement(By.XPath(Otherswithrightspanel)).Click();
           
        }

        internal void ClickAddpersonorORGButton()
        {
            driver.FindElement(By.XPath(AddnewpersonorORG)).Click();
        }

        internal void EnterAnd(string ssn, string lastname)
        {
        

            driver.FindElement(By.Name(AddSSN)).SendKeys(ssn);
            driver.FindElement(By.Name(AddSurname)).SendKeys(lastname);
        }

        internal void ClickNext()
        {
            driver.FindElement(By.Id(SubmitAddperson)).Click();
        }

        internal void ClickProvidAccessButton()
        {          

            driver.FindElement(By.XPath(AccessButton)).Click();
        }

        internal void SelectService(string service)
        {
            driver.FindElement(By.Id(DelegateserviceName)).SendKeys(service);
        }

        internal void SubmitButton(string service)
        {
   

            driver.FindElement(By.XPath("//button[@class='a-btn a-btn-icon a-btn-overlay-right a-vertical-align px-1 addBtn']")).Click();
        }

        internal void ClickSubmitButton()
        {
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(delay_time);

        }

        internal void ClickGiveRightsButton()
        {
            driver.FindElement(By.Id(GiverightsBtn)).Submit();
        }
        internal void ClickDoneButton()
        {
            driver.FindElement(By.XPath("//button[contains(text(),'Ferdig')]")).Click();
        }

       
        //driver.FindElement(By.Id(Email)).SendKeys("test@test.com");
         internal void Scrolldown()
        {
            IJavaScriptExecutor je = (IJavaScriptExecutor)driver;

            je.ExecuteScript("window.scrollBy(0,400)");
        }
        internal void GotToMyrequestsPanel()
        {
            driver.FindElement(By.XPath(MyrequestsPanel)).Click();
        }
        internal void ClickCreateNewRequestButton()
        {
            driver.FindElement(By.XPath(CreatnewRequestBtn)).Click();
        }

        internal void SelectUserInSearchList(string user)
        {
            driver.FindElement(By.Id(Searchbox)).SendKeys(user);
        }
        internal void SelectServiceForRequestAndAddService(string service)
        {
            driver.FindElement(By.XPath(SearchPerson)).Click();
            driver.FindElement(By.Id(RequestSearchinput)).SendKeys(service);
            driver.FindElement(By.ClassName("a-btn a-btn-icon a-btn-overlay-right a-vertical-align px-1 addBtn")).Click();
        }

        internal void ClickNextAndIEnterEmail()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(delay_time);

            IJavaScriptExecutor je = (IJavaScriptExecutor)driver;

            je.ExecuteScript("window.scrollBy(0,400)");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(delay_time);

            driver.FindElement(By.Name(SubmitDelegationRequest)).Click();

            driver.FindElement(By.Id(RequestEmail)).SendKeys("test@test.com");

           
        }

        internal void SendRequestAndClickDone()
        {
            driver.FindElement(By.Id(SendRequestBtn)).Submit();

            driver.FindElement(By.XPath(kvitteringrequestBtn)).Click();
        }
        


        }

    }



