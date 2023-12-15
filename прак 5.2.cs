using System;
using System.Collections.Generic;

public interface IHello
{
void SayHello();
}

public class EnglishHello : IHello
{
public void SayHello()
{
Console.WriteLine("Hello");
}
}

public class SpanishHello : IHello
{
public void SayHello()
{
Console.WriteLine("Hola");
}
}

public class FrenchHello : IHello
{
public void SayHello()
{
Console.WriteLine("Bonjour");
}
}

class Program
{
static void Main()
{
List helloList = new List
{
new EnglishHello(),
new SpanishHello(),
new FrenchHello()
};

foreach (var hello in helloList)
{
hello.SayHello();
}
}
}