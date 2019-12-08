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
            ReplyTextContainer = new WebDriverWait(driver, TimeSpan.FromSeconds(8)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='yj6qo']/preceding-sibling::div[1]")));

        }
    }
}
