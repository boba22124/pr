using System;

// Базовый класс "Человек"
public class Person
{
public string Name { get; set; } // свойство "Имя"
public int Age { get; set; } // свойство "Возраст"
public string Gender { get; set; } // свойство "Пол"

public Person(string name, int age, string gender)
{
Name = name;
Age = age;
Gender = gender;
}
}

// Наследник "Работник" со свойством "Должность"
public class Employee : Person
{
public string Position { get; set; } // дополнительное свойство "Должность"

public Employee(string name, int age, string gender, string position) : base(name, age, gender)
{
Position = position;
}
}

class Program
{
static void Main()
{
Person person = new Person("Иван", 30, "мужской");
Console.WriteLine("Человек: " + person.Name + ", Возраст: " + person.Age + ", Пол: " + person.Gender);

Employee employee = new Employee("Мария", 25, "женский", "менеджер");
Console.WriteLine("Работник: " + employee.Name + ", Возраст: " + employee.Age + ", Пол: " + employee.Gender + ", Должность: " + employee.Position);
}
}