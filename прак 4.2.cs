using System;

class Package
{
public string Description { get; private set; }
public double Weight { get; private set; }

public Package(string description, double weight)
{
Description = description;
Weight = weight;
}
}

class DeliveryService
{
public double WeightLimit { get; private set; }
private double totalWeightSent;

public DeliveryService(double weightLimit)
{
WeightLimit = weightLimit;
totalWeightSent = 0;
}

public void SendPackage(Package package)
{
if (totalWeightSent + package.Weight > WeightLimit)
{
Console.WriteLine("Ошибка: Превышен лимит веса отправленных посылок");
}
else
{
totalWeightSent += package.Weight;
Console.WriteLine($"Посылка с описанием \"{package.Description}\" отправлена успешно");
}
}
}

class PostOffice
{
static void Main()
{
DeliveryService postService = new DeliveryService(50.0); // Лимит веса отправленных посылок
Package package1 = new Package("Книги", 10.5);
Package package2 = new Package("Электроника", 20.3);
Package package3 = new Package("Одежда", 25.0);

postService.SendPackage(package1);
postService.SendPackage(package2);
postService.SendPackage(package3);
}
}