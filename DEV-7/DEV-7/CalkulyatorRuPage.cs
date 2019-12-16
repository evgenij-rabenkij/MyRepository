using System.Collections.Generic;
using OpenQA.Selenium;

namespace DEV_7
{
    public class CalkulyatorRuPage : PageObject//class, which represents page of calkulyator.ru 
    {
        public Dictionary<string, IWebElement> WebElements { get; set; } = new Dictionary<string, IWebElement>();

        public CalkulyatorRuPage(IWebDriver driver) : base(driver)
        {
            WebElements.Add("0", GetIWebElement(By.XPath("//*[@id='nmr_25']/table/tbody/tr/td")));
            WebElements.Add("00", GetIWebElement(By.XPath("//td[text()='00']")));
            WebElements.Add(".", GetIWebElement(By.XPath("//td[text()='.']")));
            WebElements.Add("1", GetIWebElement(By.XPath("//td[text()='1']")));
            WebElements.Add("2", GetIWebElement(By.XPath("//td[text()='2']")));
            WebElements.Add("3", GetIWebElement(By.XPath("//td[text()='3']")));
            WebElements.Add("4", GetIWebElement(By.XPath("//td[text()='4']")));
            WebElements.Add("5", GetIWebElement(By.XPath("//td[text()='5']")));
            WebElements.Add("6", GetIWebElement(By.XPath("//td[text()='6']")));
            WebElements.Add("7", GetIWebElement(By.XPath("//td[text()='7']")));
            WebElements.Add("8", GetIWebElement(By.XPath("//td[text()='8']")));
            WebElements.Add("9", GetIWebElement(By.XPath("//td[text()='9']")));
            WebElements.Add("+", GetIWebElement(By.XPath("//td[text()='+']")));
            WebElements.Add("=", GetIWebElement(By.XPath("//td[text()='=']")));
            WebElements.Add("*", GetIWebElement(By.XPath("//*[@id='nmr_16']/table/tbody/tr/td")));
            WebElements.Add("-", GetIWebElement(By.XPath("//td[text()='-']")));
            WebElements.Add("/", GetIWebElement(By.XPath("//td[text()='÷']")));
            WebElements.Add("^", GetIWebElement(By.XPath("//sup[text()='ʸ']")));
            WebElements.Add("√", GetIWebElement(By.XPath("//td[text()='√']")));
            WebElements.Add("M-", GetIWebElement(By.XPath("//td[text()='M-']")));
            WebElements.Add("M+", GetIWebElement(By.XPath("//td[text()='M+']")));
            WebElements.Add("MR", GetIWebElement(By.XPath("//td[text()='MR']")));
            WebElements.Add("MC", GetIWebElement(By.XPath("//td[text()='MC']"))); 
            WebElements.Add("DEL", GetIWebElement(By.XPath("//td[text()='00￫0']"))); 
            WebElements.Add("(-)", GetIWebElement(By.XPath("//td[text()='+/-']")));
            WebElements.Add("AC", GetIWebElement(By.XPath("//td[text()='AC']")));
            WebElements.Add("C", GetIWebElement(By.XPath("//td[text()='C']")));
            WebElements.Add("Display", GetIWebElement(By.Id("display")));
        }
    }
}
