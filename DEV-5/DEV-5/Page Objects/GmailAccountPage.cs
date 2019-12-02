using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;

namespace DEV_5
{
    class GmailAccountPage : PageObject
    {
        public IWebElement WriteMessageButton { get; }
        public IWebElement LastUnreadMessageBar { get; private set; }

        public GmailAccountPage(IWebDriver driver) : base(driver)
        {
            WriteMessageButton = new WebDriverWait(driver, TimeSpan.FromSeconds(15)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@jslog='20510; u014N:cOuCgd,Kr2w4b']")));
        }

        public bool FindLastUnreadMessageBar(IWebDriver driver)
        {
            LastUnreadMessageBar = new WebDriverWait(driver, TimeSpan.FromSeconds(15)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//tr[@tabindex='-1']")));
            return true; 
        }

    }                                                                                                                                                                     
}
