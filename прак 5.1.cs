using System;
using System.Collections.Generic;

class Animal
{
public virtual void PetAnimal()
{
Console.WriteLine("The animal enjoys being petted.");
}
}

class Dog : Animal
{
public override void PetAnimal()
{
Console.WriteLine("The dog wags its tail happily.");
}
}

class Cat : Animal
{
public override void PetAnimal()
{
Console.WriteLine("The cat purrs contentedly.");
}
}

class Parrot : Animal
{
public override void PetAnimal()
{
Console.WriteLine("The parrot squawks with delight.");
}
}

class Rabbit : Animal
{
public override void PetAnimal()
{
Console.WriteLine("The rabbit nuzzles your hand.");
}
}

class Hamster : Animal
{
public override void PetAnimal()
{
Console.WriteLine("The hamster runs in its wheel.");
}
}

class Program
{
static void Main(string[] args)
{
List animals = new List();
animals.Add(new Dog());
animals.Add(new Cat());
animals.Add(new Parrot());
animals.Add(new Rabbit());
animals.Add(new Hamster());

foreach (Animal animal in animals)
{
animal.PetAnimal();
}
}
}