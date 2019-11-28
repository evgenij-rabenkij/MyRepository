using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;

namespace DEV_5
{
    class MailRuMainPage : PageObject
    {
        public IWebElement LoginInputField { get; }

        public IWebElement PasswordInputField { get; private set; }

        public MailRuMainPage(IWebDriver driver) : base(driver)
        {
            LoginInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("mailbox:login")));
        }

        public bool FindPasswordInputField()
        {
            PasswordInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("mailbox:password")));
            return true;        
        }

    }
}
