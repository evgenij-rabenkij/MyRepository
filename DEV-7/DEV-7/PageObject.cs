using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DEV_7
{
    public class PageObject
    {
        protected IWebDriver driver;

        public PageObject(IWebDriver driver)
        {
            this.driver = driver;
        }
       
        protected IWebElement GetIWebElement(By elementLocator)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(elementLocator));
        }
    }
}
