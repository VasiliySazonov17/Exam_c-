string[] CreateSizeArray(string[] row)
{
    int count = 0;
    for (int i = 0; i < row.Length; i++)
    {
        if (row[i].Length <= 3)
        {
            count++;
        }
        else continue;
    }
    string[] array = new string[count];
    return array;
}

string[] FillArray(string[] row, string[] array)
{
    int count = 0;
    for (int i = 0; i < row.Length; i++)
    {
        if (row[i].Length <= 3 && count < array.Length)
        {
            array[count] = row[i];
            count++;
        }
        else continue;
    }
    return array;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length - 1)
        {
            Console.Write($", ");
        }
        else if (i == array.Length - 1)
        {
            Console.Write($". ");
            Console.WriteLine();
        }
    }
}


string[] row = { "hello", "dormer", "toy shop", "toy", "heater", "pot", "ray", "root", "air", "people" };
PrintArray(row);
string[] array = CreateSizeArray(row);
PrintArray(FillArray(row, array));
