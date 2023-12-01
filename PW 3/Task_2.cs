public class SmsMessage
{
    private string messageText;
    private float price;

    public string MessageText
    {
        get { return messageText; }
        set { messageText = value; }
    }

    public float Price
    {
        get { return price; }
        set { price = value; }
    }

    public SmsMessage(string messageText)
    {
        MessageText = messageText;

        CalculatePrice();
    }

    private void CalculatePrice()
    {
         float basePrice = 1.5f; 
         float taxRate = 0.5f;   

        if (MessageText.Length > 250)
        {
            MessageText = MessageText.Substring(0, 250);
        }
        if (MessageText.Length <= 65)
        {
            Price = basePrice;
        }
        else
        {
            Price = basePrice + (MessageText.Length - 65) * taxRate;
        }
    }
}

class Program
    {
        static void Main()
        {
            string message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
            string long_message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Curabitur pretium tincidunt lacus. Nulla gravida orci a odio. Nullam varius, turpis et commodo pharetra, est eros bibendum elit, nec luctus magna felis sollicitudin mauris. Integer in mauris eu nibh euismod gravida. Duis ac tellus et risus vulputate vehicula. Donec lobortis risus a elit. Etiam tempor. Ut ullamcorper, ligula eu tempor congue, eros est euismod turpis, id tincidunt sapien risus a quam. Maecenas fermentum consequat mi. Donec fermentum. Pellentesque malesuada nulla a mi. Duis sapien sem, aliquet nec, commodo eget, consequat quis, neque. Aliquam faucibus, elit ut dictum aliquet, felis nisl adipiscing sapien, sed malesuada diam lacus eget erat. Cras mollis scelerisque nunc. Nullam arcu. Aliquam consequat. Curabitur augue lorem, dapibus quis, laoreet et, pretium ac, nisi. Aenean magna nisl, mollis quis, molestie eu, feugiat in, orci. In hac habitasse platea dictumst.";
            SmsMessage sms = new SmsMessage(message);
            SmsMessage long_sms = new SmsMessage(long_message);

            Console.WriteLine($"Текст сообщения более 65 символов: {sms.MessageText}");
            Console.WriteLine($"Стоимость сообщения: {sms.Price} ₽");

            Console.WriteLine($"Текст сообщения более 250 символов: {long_sms.MessageText}");
            Console.WriteLine($"Стоимость сообщения: {long_sms.Price} ₽");

        Console.ReadKey(); 
        }
    }


