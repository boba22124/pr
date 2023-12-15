using System;

// Базовый класс "Транспортное средство"
public class Transport
{
public string Name { get; set; } // свойство "Название"
public int MaxSpeed { get; set; } // свойство "Максимальная скорость"

public Transport(string name, int maxSpeed)
{
Name = name;
MaxSpeed = maxSpeed;
}
}

// Политех-машина - наследник класса "Транспортное средство"
public class PolytechCar : Transport
{
public PolytechCar(string name, int maxSpeed) : base(name, maxSpeed) { }

public void PlayLoudMusic()
{
Console.WriteLine("Громко включить плохую музыку");
}
}

// Самолет - наследник класса "Транспортное средство"
public class Airplane : Transport
{
public Airplane(string name, int maxSpeed) : base(name, maxSpeed) { }

public void DustTheField()
{
Console.WriteLine("Опылить поле");
}
}

// Бетономешалка - наследник класса "Транспортное средство"
public class ConcreteMixer : Transport
{
public ConcreteMixer(string name, int maxSpeed) : base(name, maxSpeed) { }

public void MixConcrete()
{
Console.WriteLine("Мешать бетон");
}
}

class Program
{
static void Main()
{
PolytechCar car = new PolytechCar("Политех-машина 2000", 120);
car.PlayLoudMusic();

Airplane plane = new Airplane("Boeing-747", 1000);
plane.DustTheField();

ConcreteMixer mixer = new ConcreteMixer("Миксер-500", 60);
mixer.MixConcrete();
}
}