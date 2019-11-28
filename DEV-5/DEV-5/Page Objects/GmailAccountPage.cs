using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;

namespace DEV_5
{
    class GmailAccountPage : PageObject
    {
        public IWebElement WriteMessageButton { get; }
        

        public GmailAccountPage(IWebDriver driver) : base(driver)
        {
            WriteMessageButton = new WebDriverWait(driver, TimeSpan.FromSeconds(15)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@jslog='20510; u014N:cOuCgd,Kr2w4b']")));
        }

        
    }                                                                                                                                                                     
}
