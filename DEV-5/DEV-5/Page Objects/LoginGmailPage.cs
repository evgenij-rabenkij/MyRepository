
using OpenQA;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace DEV_5
{
    class LoginGmailPage : PageObject
    {
        public IWebElement loginInputField { get; }

        public LoginGmailPage(IWebDriver driver) : base(driver)
        {
            loginInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("identifierId")));
        }
    }
}
