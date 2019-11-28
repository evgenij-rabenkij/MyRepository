using OpenQA.Selenium;
using System;
using System.Threading;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DEV_5
{
    class MailRuAccountPage : PageObject
    {
        public IWebElement LastUnreadMessageBar { get; }
        public MailRuAccountPage(IWebDriver driver) : base(driver)
        {
            Thread.Sleep(15000);
            LastUnreadMessageBar = new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//a[@class='llc js-tooltip-direction_letter-bottom js-letter-list-item llc_normal']")));
        }
    }
}
