using System;

class SmsMessage
{
private string messageText;
private double basePrice;
private int maxLength;
private double extraSymbolCost;
private double price;

public SmsMessage(string message, int maxLength, double basePrice, double extraSymbolCost)
{
this.messageText = message.Length > maxLength ? message.Substring(0, maxLength) : message;
this.maxLength = maxLength;
this.basePrice = basePrice;
this.extraSymbolCost = extraSymbolCost;
CalculatePrice();
}

public string MessageText
{
get { return messageText; }
set
{
messageText = value.Length > maxLength ? value.Substring(0, maxLength) : value;
CalculatePrice();
}
}

public double Price
{
get { return price; }
}

private void CalculatePrice()
{
if (messageText.Length > maxLength)
{
price = basePrice + (messageText.Length - maxLength) * extraSymbolCost;
}
else
{
price = basePrice;
}
}
}

class Program
{
static void Main()
{
SmsMessage message1 = new SmsMessage("This is a test message.", 160, 1.5, 0.1);
Console.WriteLine("Message: {0}", message1.MessageText);
Console.WriteLine("Price: {0:C}", message1.Price);

message1.MessageText = "This is a test message with a very long text to test the extra symbol cost.";
Console.WriteLine("Message: {0}", message1.MessageText);
Console.WriteLine("Price: {0:C}", message1.Price);
}
}