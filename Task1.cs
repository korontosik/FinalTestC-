string[] array = new string[] { "Hello", "2", "world", ":-)" };

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


static void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
}


PrintArray(array);
Console.Write(" -> ");
PrintArray(newArray);


