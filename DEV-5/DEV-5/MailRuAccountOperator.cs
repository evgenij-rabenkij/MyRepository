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

        public bool MailRuReplyGmail(IWebDriver driver, string textOfReply)
        {
            
            MailRuAccountPage mailRuAccoutPage = new MailRuAccountPage(driver);
          
            mailRuAccoutPage.LastUnreadMessageBar.Click();

            MessagePage messagePage = new MessagePage(driver);

            messagePage.ReplyButton.Click();

            MessagePageWithWriteMessageWindow messagePageWithWriteMessageWindow = new MessagePageWithWriteMessageWindow(driver);

            messagePageWithWriteMessageWindow.MessageTextInputField.SendKeys(messagePageWithWriteMessageWindow.MessegeTextSpace.Text + "Received");

            messagePageWithWriteMessageWindow.SendMessageButton.Click();
            return true;
        }




    }
}
