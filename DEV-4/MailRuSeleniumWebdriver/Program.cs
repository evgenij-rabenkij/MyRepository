using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;

namespace MailRuSeleniumWebdriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "webdrivermail";
            string password = "34gadf35";
            
            IWebDriver driver = LoginMailRu(login, password);

            int numberOfUnreadMessages = int.Parse(GetNumberOfUnreadMessages(driver as ChromeDriver));

            Console.WriteLine($"Number of unread messages in {login}@mail.ru account: " + numberOfUnreadMessages);
            
            driver.Quit();
        }

        static IWebDriver LoginMailRu(string login, string password)//method for login in mail.ru account, returns ChromeDriver after login
        {
            string mailruURL = "https://mail.ru/";
           
            string idOfLoginField = "mailbox:login";
            string idOfPasswordField = "mailbox:password";
            
            int timeoutInSeconds = 5;

            IWebDriver chromeDriver = new ChromeDriver();

            chromeDriver.Navigate().GoToUrl(mailruURL);

            IWebElement loginField = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(timeoutInSeconds)).Until(ExpectedConditions.ElementIsVisible(By.Id(idOfLoginField)));
            loginField.SendKeys(login + Keys.Enter);

            IWebElement passwordField = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(timeoutInSeconds)).Until(ExpectedConditions.ElementIsVisible(By.Id(idOfPasswordField)));
            passwordField.SendKeys(password + Keys.Enter);

            return chromeDriver;
        }

        static string GetNumberOfUnreadMessages(ChromeDriver chromeDriver)//method for getting number od unread messages in mail.ru account, takes ChromeDriver, returns string number 
        {
            string idOfNumberContainer = "g_mail_events";
            
            int timeoutInSeconds = 15;
            
            IWebElement numberContainer = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(timeoutInSeconds)).Until(ExpectedConditions.ElementIsVisible(By.Id(idOfNumberContainer)));
            string numberOfUnreadMessages = numberContainer.Text;

            chromeDriver.Quit();

            return numberOfUnreadMessages;
        }
    }
}
