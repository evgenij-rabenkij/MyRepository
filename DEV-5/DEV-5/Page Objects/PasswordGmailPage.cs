
using OpenQA;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace DEV_5
{
    class PasswordGmailPage : PageObject
    {
        public IWebElement passwordInputField { get; }

        public PasswordGmailPage(IWebDriver driver) : base(driver)
        {
            passwordInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//input[@name='password']")));
        }
    }
}
