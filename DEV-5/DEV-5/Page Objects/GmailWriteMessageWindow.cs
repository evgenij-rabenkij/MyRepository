
using OpenQA;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace DEV_5
{
    class GmailWriteMessageWindow : PageObject
    {
        public IWebElement AddressOfRecipientInputField { get; }
        public IWebElement TextOfMessageInputField { get; }

        public IWebElement MessageSendButton { get; }

        public GmailWriteMessageWindow(IWebDriver driver) : base(driver)
        {
            AddressOfRecipientInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(15)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name("to")));
            TextOfMessageInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(15)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@role='textbox']")));
            MessageSendButton = new WebDriverWait(driver, TimeSpan.FromSeconds(15)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='T-I J-J5-Ji aoO v7 T-I-atl L3']")));
        }
    }
}
