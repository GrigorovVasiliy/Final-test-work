Console.Clear();

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Введите {i + 1}-й элемент массива: ");
    string stroka = Convert.ToString(Console.ReadLine());
    array[i] = stroka;
}
Console.WriteLine();
Console.WriteLine("Массив элементов: ");
Console.WriteLine(string.Join("; ", array));
Console.WriteLine();

int count = 0;
for (int i = 0; i < n; i++)
{
    if (array[i].Length <= 3)
    {
        count++;
    }
}
Console.WriteLine("Массив элементов, длинна которых меньше либо равна 3 символа: ");
string[] arrayFinish = new string[count];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        arrayFinish[j] = array[i];
        Console.Write(arrayFinish[j] + "; ");
        j++;
    }
}