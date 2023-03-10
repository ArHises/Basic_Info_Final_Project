// Make a proggram that recives given string array and return all <= 3 syblols in enather array.

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}
int CountLessThenThree(string[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3 )
        {
            counter++;
        }
    }
    return counter;
}
string[] MakeLessThenThree(string[] array)
{
    string[] newarray = new string[CountLessThenThree(array)];
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3 )
        {
            newarray[counter] = array[i];
            counter++;
        }
    }
    return newarray;
}

string[] array = {"1", "22", "333", "4444", "55555", "YES"};

PrintArray(array);
Console.WriteLine();
PrintArray(MakeLessThenThree(array));
