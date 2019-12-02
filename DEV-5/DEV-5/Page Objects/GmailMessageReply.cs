using OpenQA.Selenium;
using System;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace DEV_5
{
    class GmailMessageReply : PageObject
    {
        public IWebElement ReplyTextContainer { get; }

        public GmailMessageReply(IWebDriver driver): base(driver)
        {
            ReplyTextContainer = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//dib[@id=':7x']")));

        }
    }
}
