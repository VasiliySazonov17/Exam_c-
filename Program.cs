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

string PrintArray(string[] array)
{
    string output = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        output += ($"[{i + 1}]: {array[i]} \n");
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
    return output;
}


string[] row = { "hello", "dormer", "toy shop", "toy", "heater", "pot", "17", "to", "5", "ray", "root", "air", "people" };
string input = PrintArray(row);
File.WriteAllText("input.txt", input);
string[] array = CreateSizeArray(row);
string output = PrintArray(FillArray(row, array));
File.WriteAllText("output.txt", output);