string[] array = new string[] { "Vodka", "Матрешка", "балалайка", "3", "5", "3,14", "Пи", "int" };

string PrintArray(string[] oldarray)
{
    string newarray = "[";
    int count = oldarray.Length;
    for (int i=0; i<count; i++)
    {
        newarray+= $"{oldarray[i]},";
    }
    newarray+= "]";
    return newarray;
}
Console.WriteLine(PrintArray(array));
