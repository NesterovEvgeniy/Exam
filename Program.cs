void
Print(string[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


Console.Write("Введите количество элементов массива: ");

int num = int.Parse(Console.ReadLine());

string[] array = new string[num];

Console.WriteLine("Введите элементы массива через Enter: ");

for (int i = 0; i < array.Length; i++)
{
    array[i] = Console.ReadLine();
}

Console.WriteLine();


int index = 0;

string[] array2 = new string[num];

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        array2[index] = array[i];
        index++;
    }
}

Print(array2);
