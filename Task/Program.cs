string[] AS; 
int count; 
string[] AS2; 
int len = 0;
int index = 0;

Console.Write("count = ");
count = Int32.Parse(Console.ReadLine());

AS = new string[count];

Console.WriteLine("Fill in the array:");
FillArray(AS);
Console.WriteLine("\nArray:");
PrintArray(AS);
AS2 = new string[ResizeArray(AS, len)];
NewArray(AS, AS2, index);
Console.WriteLine("\nNew array:");
if (AS2.Length == 0) Console.WriteLine("Таких строк нет.");
else PrintArray(AS2);

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"array[{i}] = ");
        array[i] = Console.ReadLine();
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();
}

int ResizeArray(string[] array, int size)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) size++;
    }
    return size;
}

void NewArray(string[] array, string[] new_array, int j)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            new_array[j] = array[i];
            j++;
        }
    }
}
