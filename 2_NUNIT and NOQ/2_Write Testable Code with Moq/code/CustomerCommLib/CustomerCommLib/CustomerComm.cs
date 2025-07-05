namespace CustomerCommLib
{
    public class CustomerComm
    {
        IMailSender _mailSender;

        public CustomerComm(IMailSender mailSender)
        {
            _mailSender = mailSender;
        }

        public bool SendMailToCustomer()
        {
            string to = "cust123@abc.com";
            string msg = "Some Message";

            _mailSender.SendMail(to, msg);

            return true;
        }
    }
}
