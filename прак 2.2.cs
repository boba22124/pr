using System;

class NumberIncrementer
{
private int p = 0;

public bool SetNumber(int number)
{
if (number == p + 1)
{
p = number;
return true;
}
else
{
p = 0;
return false;
}
}

public int GetExpectedNumber()
{
return p + 1;
}
}

class Program
{
static void Main(string[] args)
{
NumberIncrementer incrementer = new NumberIncrementer();

Console.WriteLine("Please enter the number 1:");

while (true)
{
int input;
if (int.TryParse(Console.ReadLine(), out input))
{
if (incrementer.SetNumber(input))
{
Console.WriteLine("Please enter the number " + incrementer.GetExpectedNumber() + ":");
}
else
{
Console.WriteLine("Incorrect number. Please enter the number 1 to start again:");
}
}
else
{
Console.WriteLine("Invalid input. Please enter a valid number:");
}
}
}
}