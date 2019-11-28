using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace DEV_5
{
    class GMailAccountOperator
    {
        const string gmailMainPageURL = "https://www.google.com/intl/ru/gmail/about/#";

        public GMailAccountOperator()
        { 
        }

        public IWebDriver LoginToGmailAccount(string gmailLogin, string gmailPassword)
        {
            IWebDriver chromeDriver = new ChromeDriver();
            chromeDriver.Manage().Window.Maximize();

            chromeDriver.Navigate().GoToUrl(gmailMainPageURL);
            GmailMainPage gmailMainPage = new GmailMainPage(chromeDriver);
            gmailMainPage.SignInButton.Click();

            List<string> tabs = new List<string>(chromeDriver.WindowHandles);
            chromeDriver.SwitchTo().Window(tabs[1]);

            LoginGmailPage loginGmailPage = new LoginGmailPage(chromeDriver);
            loginGmailPage.loginInputField.SendKeys(gmailLogin + Keys.Enter);

            PasswordGmailPage passwordGmailPage = new PasswordGmailPage(chromeDriver);
            passwordGmailPage.passwordInputField.SendKeys(gmailPassword + Keys.Enter);

            return chromeDriver;
        }

        public bool SendFromGmailToMailRuMessage(IWebDriver driver, string mailruFullLogin, string textOfMessege)
        {
            GmailAccountPage gmailAccountPage = new GmailAccountPage(driver);
            gmailAccountPage.WriteMessageButton.Click();

            GmailAccountPageWithWriteMessageWindow gmailAccountPageWithWriteMessageWindow = new GmailAccountPageWithWriteMessageWindow(driver);
            gmailAccountPageWithWriteMessageWindow.AddressOfRecipientInputField.SendKeys(mailruFullLogin);
            gmailAccountPageWithWriteMessageWindow.TextOfMessageInputField.SendKeys(textOfMessege);
            gmailAccountPageWithWriteMessageWindow.MessageSendButton.Click();
            return true;
        }
    }
}
