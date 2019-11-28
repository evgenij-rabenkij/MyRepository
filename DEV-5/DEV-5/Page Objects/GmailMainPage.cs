using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;


namespace DEV_5
{
    class GmailMainPage : PageObject
    {
        protected IWebDriver driver;
        public IWebElement SignInButton { get; }

        public GmailMainPage(IWebDriver driver) :base(driver)
        {
            SignInButton = new WebDriverWait(driver, TimeSpan.FromSeconds(3)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//ul[@class='h-c-header__cta-list header__nav--ltr']/li[2]/a")));
        }
    }
}




