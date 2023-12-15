
using System;

class Car
{
public string Name { get; set; }
public int MaxSpeed { get; set; }

public Car(string name, int maxSpeed)
{
Name = name;
MaxSpeed = maxSpeed;
}

public void DisplayInfo()
{
Console.WriteLine($"Автомобиль {Name} имеет максимальную скорость {MaxSpeed} км/ч.");
}
}

class Program
{
static void Main(string[] args)
{
Car car1 = new Car("paganihuayra", 320);
Car car2 = new Car("protonperdana", 310);
Car car3 = new Car("toyotaOPA", 330);
Car car4 = new Car("McLaren", 340);

car1.DisplayInfo();
car2.DisplayInfo();
car3.DisplayInfo();
car4.DisplayInfo();

Console.WriteLine("\Начинаем гонку!");

Car[] cars = new Car[] { car1, car2, car3, car4 };
string winner = GetWinner(cars);
Console.WriteLine($"Победитель гонки: {winner}");
}

static string GetWinner(Car[] cars)
{
int maxSpeed = 0;
string winner = "";
foreach (Car car in cars)
{
if (car.MaxSpeed > maxSpeed)
{
maxSpeed = car.MaxSpeed;
winner = car.Name;
}
}
return winner;
}
}