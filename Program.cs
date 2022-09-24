string[] row = { "dormer", "toy shop", "toy", "=)", "heater", "pot", "ray", "root", "air" };

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

