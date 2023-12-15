using System;

public interface IMagic
{
void CastSpell(int manaRequired);
}

public class Wizard : IMagic
{
public string Name { get; set; }
public int Mana { get; set; }

public Wizard(string name, int mana)
{
Name = name;
Mana = mana;
}

public void CastSpell(int manaRequired)
{
if (Mana < manaRequired)
{
Console.WriteLine($"Для использования заклинания не хватает {manaRequired - Mana} единиц маны. Хлебните зелья!");
}
else
{
Console.WriteLine($"{Name} колдует! Эффект от заклинания: Абракадабра! >>");
Mana -= manaRequired;
}
}
}

class Program
{
static void Main()
{
Wizard merlin = new Wizard("Мерлин", 50);
Wizard gandalf = new Wizard("Гэндальф", 100);

merlin.CastSpell(30);
merlin.CastSpell(40);

gandalf.CastSpell(80);
gandalf.CastSpell(120);
}
}