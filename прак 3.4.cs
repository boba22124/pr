using System;

class MyIntList
{
private int[] list;
private int count;

public MyIntList()
{
list = new int[10]; // начальный размер списка
count = 0;
}

public int Count
{
get { return count; }
}

public void Add(int item)
{
if (count < list.Length)
{
list[count] = item;
count++;
}
else
{
// Создание нового списка с увеличенной ёмкостью
int[] newList = new int[list.Length * 2];
Array.Copy(list, newList, list.Length);
list = newList;

// добавление элемента в список
list[count] = item;
count++;
}
}
}

class Program
{
static void Main()
{
MyIntList intList = new MyIntList();
intList.Add(3);
intList.Add(7);
intList.Add(11);
Console.WriteLine("Count: {0}", intList.Count);
}
}