using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Pagefiles
{
    public class ORangeHRMPageFiles
    {
        IWebDriver driver;
        public string HRMUrl => "https://www.orangehrm.com/";
        public string ContactsalesButton => "//a[contains(text(),'Contact Sales')]";
        public string FirstName => "#Form_submitForm_FirstName";
        public string SecondName => "Form_submitForm_LastName";
        public string CompanyName => "//input[@placeholder='Company Name']";
        public string NoofEmployees => "//select[@id='Form_submitForm_NoOfEmployees']";
        public string JobTitle => "//input[@id='Form_submitForm_JobTitle' and @name='JobTitle']";
        public string ContactNumber => "Contact";
        public string Email => "Form_submitForm_Email";
        public string CountryNorway => "Form_submitForm_Country";
        public string Comment => "Comment";
        public string Submit => "//input[@id='Form_submitForm_action_request']";
        internal void ChromeBrowser()
        {
            driver = new ChromeDriver();
        }
        internal void OrgangeHRMPage()
        {
            driver.Navigate().GoToUrl(HRMUrl);
            driver.Manage().Window.Maximize();
        }
        internal void ClickContactsalesButton()
        {
            driver.FindElement(By.XPath(ContactsalesButton)).Click();
        }
        internal void FillTheFields(string firstname, string secondname, string companyname)
        {
            driver.FindElement(By.CssSelector(FirstName)).SendKeys(firstname);
            driver.FindElement(By.Id(SecondName)).SendKeys(secondname);
            driver.FindElement(By.XPath(CompanyName)).SendKeys(companyname);
        }
        internal void NumberOfEmployeesGroup()
        {
            //Dropdown list 
            IWebElement numempselect = driver.FindElement(By.XPath(NoofEmployees));
            SelectElement numberofemployees = new SelectElement(numempselect);
            numberofemployees.SelectByValue("16 - 20");
            //numberofemployees.SelectByText("16 - 20");
            //IList<IWebElement> elementcounts = numberofemployees.Options;
            //Console.WriteLine(elementcounts);
        }
        internal void Fillinfoof(string jobtitle, string contactno, string email)
        {
            driver.FindElement(By.XPath(JobTitle)).SendKeys(jobtitle);
            driver.FindElement(By.Name(ContactNumber)).SendKeys(contactno);
            driver.FindElement(By.Id(Email)).SendKeys(email);
        }
        internal void CountryandComment()
        {
            IWebElement country = driver.FindElement(By.Id(CountryNorway));
            SelectElement countryselect = new SelectElement(country);
            countryselect.SelectByText("Norway");
            driver.FindElement(By.Name(Comment)).SendKeys("This is Automation test of OrangeHRM websige" +
                " using selenium C# with specflow BDD framework for differnt " +
                "scenarios in chrome browser!! \n ***************Have a wonderful DAY***********");
        }
        internal void ScrollDownAndSubmit()
        {
            IJavaScriptExecutor je = (IJavaScriptExecutor)driver;
            je.ExecuteScript("window.scrollBy(0,800)");
            //driver.FindElement(By.Id("recaptcha-anchor")).Click();
            //driver.FindElement(By.XPath("//*[id='recaptcha-anchor' and @aria-checked='true'")).Click();
            //je.ExecuteScript("arguments[0].scrollIntoView(false);", s);

            driver.FindElement(By.XPath(Submit)).Click();
        }
    }
}
