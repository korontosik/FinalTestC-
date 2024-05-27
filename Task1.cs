Commands();
string[] array = new string[] {};
string fromUser = ReadInput("Введите команду: ");
switch (fromUser)
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
        Console.WriteLine($"{fromUser} - Такой команды нет");
        break;
}

int newArrayLen = 0;

for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3) newArrayLen++;
}

string[] newArray = new string[newArrayLen];
int count = 0;

for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[count] = array[i];
        count++;
    }
}

string ReadInput(string msg)
{
    Console.Write(msg);
    return Console.ReadLine();
}

static void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"“{array[i]}” ");
    }
    Console.Write("] ");
}

void Commands()
{
    Console.WriteLine();
    Console.WriteLine("Команды:");
    Console.WriteLine("1 – [“Hello”, “2”, “world”, “:-)”]");
    Console.WriteLine("2 – [“1234”, “1567”, “-2”, “computer science”]");
    Console.WriteLine("3 – [“Russia”, “Denmark”, “Kazan”]");
    Console.WriteLine();
}


PrintArray(array);
Console.Write("-> ");
PrintArray(newArray);


