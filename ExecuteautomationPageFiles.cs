using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;


namespace ConsoleApp2.Pagefiles
{
    public interface IExecuteautomationInterface //interface
    {
        void NavigateToExecuteautomation();
        void ClickExecuteAutomationLogin();
        void EnterUsernameAndPassword(string username, string password);
        void UserIsLoggedIn();
    }
    public class ExecuteautomationPageFiles 
    {
        
        public ExecuteautomationPageFiles()
        {
            
        }
        public string eaurl => "http://eaapp.somee.com/";
        public string Loginlink => "loginLink"; 
        public string Username => "UserName";
        public string Password => "Password";
        public string Login => "//input[@value='Log in']";

        IWebDriver driver = new ChromeDriver();
        internal void  NavigateToExecuteautomation()
        { 

            driver.Navigate().GoToUrl(eaurl);
            Thread.Sleep(6000);
           
        }
        internal void ClickExecuteAutomationLogin()
        {
            driver.FindElement(By.Id(Loginlink)).Click();
        }
        internal void EnterUsernameAndPassword(string username, string password)
        {
            driver.FindElement(By.Id(Username)).SendKeys(username);
            driver.FindElement(By.Name(Password)).SendKeys(password);
            Thread.Sleep(4000);
        }
        internal void UserIsLoggedIn()
        {
            IWebElement login = driver.FindElement(By.XPath(Login));
            Assert.IsTrue(login.Displayed);
            login.Submit();
        }
    }
}
