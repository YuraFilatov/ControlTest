string PrintArray(string[] oldarray)
{
    string newarray = "[";
    int count = oldarray.Length;
    for (int i = 0; i < count; i++)
    {
        if (oldarray[i].Length <= 3) 
        {
            if (i == oldarray.Length - 1) 
                newarray += $"{oldarray[i]}";
            else newarray+= $"{oldarray[i]},";
        }
    }
    newarray += "]";
    return newarray;
}

string[] array = new string[] { "Vodka", "Матрешка", "балалайка", "3", "5", "3,14", "Пи", "int", "res" };

Console.WriteLine(PrintArray(array));
