using System;
using System.Collections.Generic;
using OpenQA;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

using OpenQA.Selenium.Support.UI;

namespace DEV_5
{
    class MailRuAccountOperator
    {
        const string mailRuMainPageURL = "https://mail.ru/";
        public MailRuAccountOperator()
        {
        }

        public IWebDriver LoginToMailRuAccount(string gmailLogin, string gmailPassword)
        {
            IWebDriver chromeDriver = new ChromeDriver();
            chromeDriver.Manage().Window.Maximize();


            chromeDriver.Navigate().GoToUrl(mailRuMainPageURL);
            MailRuMainPage mailRuMainPage = new MailRuMainPage(chromeDriver);
            mailRuMainPage.LoginInputField.SendKeys(gmailLogin + Keys.Enter);

            mailRuMainPage.FindPasswordInputField();
            mailRuMainPage.PasswordInputField.SendKeys(gmailPassword + Keys.Enter);
            return chromeDriver;
        }

        public bool MailRuReplyGmail(IWebDriver driver)
        {
            MailRuAccountPage mailRuAccoutPage = new MailRuAccountPage(driver);
          
            mailRuAccoutPage.LastUnreadMessageBar.Click();

            LastUnredMessageMailRuPage lastUnredMessageMailRuPage = new LastUnredMessageMailRuPage(driver);

            lastUnredMessageMailRuPage.ReplyButton.Click();

            MailRuReplyingMessageWindow mailRuReplyingMessageWindow = new MailRuReplyingMessageWindow(driver);

            mailRuReplyingMessageWindow.ReplyMessageTextInputField.SendKeys(lastUnredMessageMailRuPage.MessegeTextSpace.Text + " Received");

            mailRuReplyingMessageWindow.SendMessageButton.Click();
            
            return true;
        }




    }
}
