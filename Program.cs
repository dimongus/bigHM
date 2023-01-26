
Console.WriteLine();
    Console.WriteLine("Выберите массив:");
    Console.WriteLine("1  массив: [“Hello”, “2”, “world”, “:-)”]");
    Console.WriteLine("2  массив: [“1234”, “1567”, “-2”, “computer science”]");
    Console.WriteLine("3  массив: [“Russia”, “Denmark”, “Kazan”]");
    Console.WriteLine();
string[] array = new string[] {};

string command = ReadInput("Введите команду: ");
switch (command)
{
    case "1":
        array = new string[] { "Hello", "2", "world", ":-)" };
        break;
    case "2":
        array = new string[] { "1234", "1567", "-2", "computer science" };
        break;
    case "3":
        array = new string[] { "Russia", "Denmark", "Kazan" };
        break;
    default:
        Console.WriteLine($"{command} - Такой команды нет");
        break;
}

int lenghtArray = 0;
for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3) lenghtArray++;
}

string[] newArray = new string[lenghtArray];
int count = 0;

for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[count] = array[i];
        count++;
    }
}

PrintArray(array);
Console.Write("→ ");
PrintArray(newArray);


string ReadInput(string msg)
{
    Console.Write(msg);
    return Console.ReadLine();
}

void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"“{array[i]}”, ");
    }
    Console.Write("] ");
}