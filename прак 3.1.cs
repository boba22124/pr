using System;

class Color
{
private int red;
private int green;
private int blue;

public Color()
{
red = 0;
green = 0;
blue = 0;
}

public Color(int r, int g, int b)
{
red = r;
green = g;
blue = b;
}

public void SetRed(int r)
{
if (r >= 0 && r <= 255)
{
red = r;
}
}

public void SetGreen(int g)
{
if (g >= 0 && g <= 255)
{
green = g;
}
}

public void SetBlue(int b)
{
if (b >= 0 && b <= 255)
{
blue = b;
}
}

public void Display()
{
Console.WriteLine("Red: {0}, Green: {1}, Blue: {2}", red, green, blue);
}
}

class Program
{
static void Main()
{
Color myColor = new Color(100, 150, 200);
myColor.Display();

myColor.SetRed(120);
myColor.SetGreen(180);
myColor.SetBlue(220);
myColor.Display();
}
}