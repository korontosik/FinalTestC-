string[] array = new string[] { "Hello", "2", "world", ":-)" };

int newArrayLen = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) newArrayLen++;

}
string[] newArray = new string[newArrayLen];
int count = 0;
for (int i = 0; i < array.Length - 1; i++)
{
    if (array[i].Length <=3){
        newArray[count] = array[i];
        count++;
    }
}


for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}