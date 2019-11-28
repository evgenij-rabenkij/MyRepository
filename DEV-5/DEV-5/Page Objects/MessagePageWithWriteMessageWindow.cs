
using OpenQA;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace DEV_5
{
    class MessagePageWithWriteMessageWindow : MessagePage
    {
        public IWebElement MessageTextInputField{ get; }
        public IWebElement SendMessageButton { get; }
        public MessagePageWithWriteMessageWindow(IWebDriver driver) : base(driver)
        {
            MessageTextInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='editable-container-gn3w']")));
            SendMessageButton = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='app-canvas']/div/div[1]/div[1]/div/div[2]/div[2]/div/div/div/div/div/div/div[3]/div[1]/div[3]/div/div/div[1]/div/span/span/span[2]")));
        }
    }
}
