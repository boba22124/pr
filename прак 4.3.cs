using System;

class Orc
{
private static int totalGoldCarried = 0;
private static int orcCount = 0;
private int goldCarried;

public int GoldCarried
{
get { return goldCarried; }
set { goldCarried = value; }
}

public Orc()
{
orcCount++;
if (orcCount > 5)
{
goldCarried = totalGoldCarried - (2 * (orcCount - 5));
}
else
{
goldCarried = totalGoldCarried + 2;
}
if (orcCount > 5)
{
goldCarried -= 2 * (orcCount - 5);
}
totalGoldCarried += goldCarried;
}

public static void Main(string[] args)
{
Orc orc1 = new Orc();
Orc orc2 = new Orc();
Orc orc3 = new Orc();

Console.WriteLine("Orc 1 gold carried: " + orc1.GoldCarried);
Console.WriteLine("Orc 2 gold carried: " + orc2.GoldCarried);
Console.WriteLine("Orc 3 gold carried: " + orc3.GoldCarried);
}
}