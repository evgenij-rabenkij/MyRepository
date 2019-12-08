using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;

namespace DEV_5
{
    class MailRuReplyingMessageWindow : PageObject
    {
        public IWebElement ReplyMessageTextInputField { get; }
        public IWebElement SendMessageButton { get; }

        public MailRuReplyingMessageWindow(IWebDriver driver) : base(driver)
        {
            ReplyMessageTextInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(15)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@role='textbox']")));
            SendMessageButton = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[@tabindex='570']")));
        }
    }
}
