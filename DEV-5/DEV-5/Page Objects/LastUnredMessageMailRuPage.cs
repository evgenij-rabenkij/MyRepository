
using OpenQA;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace DEV_5
{
    class LastUnredMessageMailRuPage : PageObject
    {
        public IWebElement MessegeTextSpace{get;}
        public IWebElement ReplyButton { get; }
        public LastUnredMessageMailRuPage(IWebDriver driver) : base(driver)
        {
                
            MessegeTextSpace = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@dir='ltr']")));
            ReplyButton = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[@class='button2 button2_has-ico button2_reply button2_clean button2_hover-support js-shortcut']")));
        }
    }
}
