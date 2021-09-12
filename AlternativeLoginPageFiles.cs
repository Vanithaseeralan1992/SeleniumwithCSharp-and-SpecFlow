using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Pagefiles
{
    public class AlternativeLoginPageFiles
    {
        public IWebDriver WebDriver { get; }
        public AlternativeLoginPageFiles(IWebDriver webDriver)
            {
            WebDriver = webDriver;
            }

        public string Url => "https://at24.altinn.cloud/";
        public string Login => "//button[@type='button' and @class='a-btn a-btn-border']";
        public string AlternativeLogin => "otherLoginLink";
        public string SSN_input => "SSN_Input";
        public string Pin_one => "AltinnPinOneRequest_Pin";
        public string SubmitFirstPin => "submitFirstPinBtn";
        public int delay_time => 8;
        public string Pin_two => "AltinnPinTwoRequest_Pin";
        public string SubmitSecondPin => "submitSecondPinBtn";

         IWebDriver webDriver = new ChromeDriver();


        internal void LaunchChromeBrowserAndNavigateToTestenvironment()
        {
            webDriver.Navigate().GoToUrl(Url);
            webDriver.Manage().Window.Maximize();
        }

        internal void ClickLogin()
        {
            webDriver.FindElement(By.XPath(Login)).Click();
        }
        internal void ClickAlternativeLogin()
        {
            webDriver.FindElement(By.Id(AlternativeLogin)).Click();
        }
        internal void EnterSSNAndPinOne(string ssn, string pinone)
        {
            webDriver.FindElement(By.Id(SSN_input)).SendKeys(ssn);
            webDriver.FindElement(By.Id(Pin_one)).SendKeys(pinone);

        }
        internal void Submit_FirstPin()
        {
            webDriver.FindElement(By.Id(SubmitFirstPin)).Click();
        }
        internal void EnterPinTwo(string pintwo)
        {
            webDriver.FindElement(By.Id(Pin_two)).SendKeys(pintwo);
        }
        internal void Submit_SecondPin()
        {
            webDriver.FindElement(By.Id(SubmitSecondPin)).Click();
        }
        internal void ShouldLogIn()
        {
            Assert.Pass("User is logged in");
        }

        internal void Wait()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(delay_time);
        }
    }
}
