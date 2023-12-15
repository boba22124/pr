using System;

class Wizard
{
public int Mana { get; private set; }
public string Name { get; private set; }

public Wizard(string name, int mana)
{
Name = name;
Mana = mana;
}

public void CastSpell(string spell, int manaRequired, string effect)
{
if (Mana < manaRequired)
{
Console.WriteLine($"Для использования {spell} не хватает {manaRequired - Mana} единиц маны. Хлебните зелья!");
}
else
{
Mana -= manaRequired;
Console.WriteLine($"{Name} колдует! -{effect}>>");
}
}
}

class Program
{
static void Main()
{
Wizard merlin = new Wizard("Мерлин", 10);
merlin.CastSpell("Огненный шар", 5, "Полымя");

// Попробуем использовать заклинание, когда не хватает маны
merlin.CastSpell("Ледяное прикосновение", 8, "Ледяная стена");
}
}