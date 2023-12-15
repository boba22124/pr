using System;

class SmsMessage
{
private string messageText;
private double price;

public string MessageText
{
get { return messageText; }
set
{
if (value.Length > 250)
{
messageText = value.Substring(0, 250);
}
else
{
messageText = value;
}

if (messageText.Length <= 65)
{
price = 1.5;
}
else
{
price = 1.5 + (messageText.Length - 65) * 0.5;
}
}
}

public double Price
{
get { return price; }
private set { price = value; }
}
}

class Program
{
static void Main()
{
SmsMessage message = new SmsMessage();
message.MessageText = "Hello, this is an example of a short message.";
Console.WriteLine("Message: {0}", message.MessageText);
Console.WriteLine("Price: {0}", message.Price);

message.MessageText = "Hello, this is an example of a long message. It will exceed the limit of 65 characters and incur additional charges for each extra character.";
Console.WriteLine("Message: {0}", message.MessageText);
Console.WriteLine("Price: {0}", message.Price);
}
}