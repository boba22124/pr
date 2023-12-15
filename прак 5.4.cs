using System;

public interface IShape
{
void Draw(int size);
}

public class VerticalLine : IShape
{
public void Draw(int size)
{
for (int i = 0; i < size; i++)
{
Console.WriteLine("|");
}
}
}

public class HorizontalLine : IShape
{
public void Draw(int size)
{
for (int i = 0; i < size; i++)
{
Console.Write("-");
}
Console.WriteLine();
}
}

public class Square : IShape
{
public void Draw(int size)
{
for (int i = 0; i < size; i++)
{
if (i == 0 || i == size - 1)
{
for (int j = 0; j < size; j++)
{
Console.Write("*");
}
}
else
{
Console.Write("*");
for (int j = 0; j < size - 2; j++)
{
Console.Write(" ");
}
Console.Write("*");
}
Console.WriteLine();
}
}
}

class Program
{
static void Main()
{
IShape verticalLine = new VerticalLine();
IShape horizontalLine = new HorizontalLine();
IShape square = new Square();

int size = 5;

Console.WriteLine("Vertical Line:");
verticalLine.Draw(size);

Console.WriteLine("\nHorizontal Line:");
horizontalLine.Draw(size);

Console.WriteLine("\nSquare:");
square.Draw(size);
}
}