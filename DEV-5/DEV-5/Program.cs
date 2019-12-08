using OpenQA.Selenium;
using System;

namespace DEV_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input text of message: ");
            string textOfMessege = Console.ReadLine();
            
            string gmailLogin = "webdrivermailg";
            string gmailPassword = "34gadf35";

            string mailruFullLogin = "webdrivermail@mail.ru";

            string loginMailRu = "webdrivermail";
            string passwordMailRu = "34gadf35";

            GMailAccountOperator gmailAccountOperator = new GMailAccountOperator();

            IWebDriver driverGmail = gmailAccountOperator.LoginToGmailAccount(gmailLogin, gmailPassword);

            gmailAccountOperator.SendFromGmailToMailRuMessage(driverGmail, mailruFullLogin, textOfMessege);


            MailRuAccountOperator mailRuAccountOperator = new MailRuAccountOperator();

            IWebDriver driverMailRu = mailRuAccountOperator.LoginToMailRuAccount(loginMailRu, passwordMailRu);

            mailRuAccountOperator.MailRuReplyGmail(driverMailRu);

            driverMailRu.Quit();

            gmailAccountOperator.ReadReplyFromMailRu(driverGmail);

            driverGmail.Quit();
        }
    }
}