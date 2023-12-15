using System;

class SQLCommand
{
private string commandText;

public string CommandText
{
get { return commandText; }
set { commandText = value.ToUpper(); }
}
}

class Program
{
static void Main()
{
SQLCommand command = new SQLCommand();
command.CommandText = "select * from table where id = 1";
Console.WriteLine("Command Text: {0}", command.CommandText);
}
}