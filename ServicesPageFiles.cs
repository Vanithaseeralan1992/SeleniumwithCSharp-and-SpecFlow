using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Stepdefinitions
{
    
   public class ServicesPageFiles
    {
        IWebDriver driver = new ChromeDriver();
        public string AvailableserviesUrl => "https://at24.altinn.cloud/pages/temp/availableservices.aspx";
        public string ReportingDropdown => "ctl00$ctl00$MasterPageContent$PageContent$DropDownList3";
        public string ServiceSelect => "ctl00$ctl00$MasterPageContent$PageContent$DropDownList1";
        public string StartServiceBtn => "ctl00_ctl00_MasterPageContent_PageContent_startServiceButton";
        public string ServiceContinueBtn => "ctl00$ctl00$MasterPageContent$PageContent$ctlChooseReportee$btnContinue";
        public string Continueskjema => "ctl00_ctl00_MasterPageContent_PageContent_ctlActiveReporteeElement_btnContinue";
        public string Name => "ctl00_ctl00_MasterPageContent_PageContent_XmlFormView1_V1_I1_T11";
        public string Address => "ctl00_ctl00_MasterPageContent_PageContent_XmlFormView1_V1_I1_T13";
        public string Postno => "ctl00_ctl00_MasterPageContent_PageContent_XmlFormView1_V1_I1_T15";
        public string Sted => "ctl00_ctl00_MasterPageContent_PageContent_XmlFormView1_V1_I1_T16";
        public string SkattRadioBtn => "ctl00_ctl00_MasterPageContent_PageContent_XmlFormView1_V1_I1_O26";
        public string FolkeregisterRadioBtn => "ctl00_ctl00_MasterPageContent_PageContent_XmlFormView1_V1_I1_O33";
        public string Page2Link => "//a[contains(text(),'Side 2')]";
        public string Year=> "ctl00_ctl00_MasterPageContent_PageContent_XmlFormView1_V1_I1_D5";
        public string MultilineTxtbox1 => "ctl00_ctl00_MasterPageContent_PageContent_XmlFormView1_V1_I1_S7_I4_T3";
        public string MultilineTxtbox2 => "ctl00_ctl00_MasterPageContent_PageContent_XmlFormView1_V1_I1_T13";
        public string Page1Link => "//a[contains(text(),'Side 1')]";
        public string Email => "//input[@id='ctl00_ctl00_MasterPageContent_PageContent_XmlFormView1_V1_I1_T18']";
        public string Telephone => "ctl00_ctl00_MasterPageContent_PageContent_XmlFormView1_V1_I1_T20";
        public string Validateform => "ctl00_ctl00_MasterPageContent_PageContent_ValidateForm";
        public string CloseValidationPopup => "ctl00_ctl00_MasterPageContent_PageContent_CloseValidationPopup";
        public string VideretilSignering => "ctl00_ctl00_MasterPageContent_PageContent_SendForm";
        public string SignerogSEndin => "ctl00_ctl00_MasterPageContent_PageContent_btnPerformCurrentStep";
        public string Logout => "ctl00_ctl00_MasterPageHeader_ucTopBannerSmall_ucLoginReportee_hlLogout";

        internal void NavigateToAvailableServices()
        {
            driver.Navigate().GoToUrl(AvailableserviesUrl);
            driver.Manage().Window.Maximize();
        }
        internal void SelectServiceAndServiceType(string enterservice, string enterservicetype)
        {
            IWebElement service = driver.FindElement(By.Name(ServiceSelect));

            SelectElement serviceselect = new SelectElement(service);

            serviceselect.SelectByText(enterservice);
            IWebElement servicetype = driver.FindElement(By.Name(ReportingDropdown));

            SelectElement servicetypeselect = new SelectElement(servicetype);

            servicetypeselect.SelectByText(enterservicetype);

        }

        internal void ActivateServiceClickContinueWithUserContinueWithFormService()
        {
            driver.FindElement(By.Id(StartServiceBtn)).Click();

            driver.FindElement(By.Name(ServiceContinueBtn)).Click();

            driver.FindElement(By.Id(Continueskjema)).Click();
        }

        internal void FillOutPageOne(string name, string address, string postno, string sted)
        {
            driver.FindElement(By.Id(Name)).SendKeys("Vanitha Seeralan");

            driver.FindElement(By.Id(Address)).SendKeys("Lørenskog");

            driver.FindElement(By.Id(Postno)).SendKeys("1461");

            driver.FindElement(By.Id(Sted)).SendKeys("Lørenskog");

            driver.FindElement(By.Id(SkattRadioBtn)).Click();

            driver.FindElement(By.Id(FolkeregisterRadioBtn)).Click();
        }

        internal void FillOutPageTwo()
        {

            driver.FindElement(By.XPath(Page2Link)).Click();

            IWebElement year = driver.FindElement(By.Id(Year));

            SelectElement yearselect = new SelectElement(year);

            yearselect.SelectByText("2003");
            driver.FindElement(By.Id(MultilineTxtbox1)).SendKeys("Sample text for testing mulitiline text box1");
            driver.FindElement(By.Id(MultilineTxtbox2)).SendKeys("Sample text for testing mulitiline text box2");
            driver.FindElement(By.XPath(Page1Link)).Click();
            string mail = "Vanitha@gmail.com";
            IWebElement email = driver.FindElement(By.XPath(Email));
            email.SendKeys(mail);
            driver.FindElement(By.Id(Telephone)).Click();
        }

        internal void ClickControllSkjema()
        {

            driver.FindElement(By.Id(Validateform)).Click();            
        }

        internal void ClosePopupAlertBoxAndClickContinueToSignAndSubmitForm()
        {
            driver.FindElement(By.Id(CloseValidationPopup)).Click();

            driver.FindElement(By.Id(VideretilSignering)).Click();

            driver.FindElement(By.Id(SignerogSEndin)).Click();
        }
        internal void Wait()
        {
            int delay_time = 10;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(delay_time);
        }
        internal void LogoutandCloseBrowser()
        {


            driver.FindElement(By.Id(Logout)).Click();

            driver.Close();

        }




       
    }
}
