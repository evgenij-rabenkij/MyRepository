
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Xml.XPath;


namespace DEV_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string textOfMessege = "Last";
            string textOfReply = "The message is received.";
            
            string gmailLogin = "webdrivermailg";
            string gmailPassword = "34gadf35";

            string mailruFullLogin = "webdrivermail@mail.ru";

            string loginMailRu = "webdrivermail";
            string passwordMailRu = "34gadf35";

            //GMailAccountOperator gmailAccountOperator = new GMailAccountOperator();

            //IWebDriver driverGmail = gmailAccountOperator.LoginToGmailAccount(gmailLogin, gmailPassword);

            //gmailAccountOperator.SendFromGmailToMailRuMessage(driverGmail, mailruFullLogin, textOfMessege);


            MailRuAccountOperator mailRuAccountOperator = new MailRuAccountOperator();

            IWebDriver driverMailRu = mailRuAccountOperator.LoginToMailRuAccount(loginMailRu, passwordMailRu);

            mailRuAccountOperator.MailRuReplyGmail(driverMailRu, textOfReply);


        }
    }
}