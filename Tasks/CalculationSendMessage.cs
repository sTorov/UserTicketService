namespace Tasks
{
    public class CalculationSendMessage
    {
        IMailSender _sender;
        public CalculationSendMessage(IMailSender sender)
        {
            _sender = sender;
        }

        public int Multiplication(int a, int b)
        {
            _sender.Send();

            return a * b;
        }
    }
}
