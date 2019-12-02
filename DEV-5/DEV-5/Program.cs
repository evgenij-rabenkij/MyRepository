using OpenQA.Selenium;

namespace DEV_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string textOfMessege = "Unique number: 5809.";
            string textOfReply = "The message is received.";
            
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

            mailRuAccountOperator.MailRuReplyGmail(driverMailRu, textOfReply);

            driverMailRu.Quit();

            gmailAccountOperator.ReadReplyFromMailRu(driverGmail);

            driverGmail.Quit();
        }
    }
}