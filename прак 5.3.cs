using System;
using System.Text.RegularExpressions;

public interface IFilter
{
string Execute(string textLine);
}

public class DigitFilter : IFilter
{
public string Execute(string textLine)
{
return Regex.Replace(textLine, "[0-9]", "");
}
}

public class LetterFilter : IFilter
{
public string Execute(string textLine)
{
return Regex.Replace(textLine, "[a-zA-Z]", "");
}
}

class Program
{
static void Main()
{
IFilter digitFilter = new DigitFilter();
IFilter letterFilter = new LetterFilter();

string inputText = "abc123def456ghi";

string filteredDigits = digitFilter.Execute(inputText);
Console.WriteLine("Filtered Digits: " + filteredDigits);

string filteredLetters = letterFilter.Execute(inputText);
Console.WriteLine("Filtered Letters: " + filteredLetters);
}
}