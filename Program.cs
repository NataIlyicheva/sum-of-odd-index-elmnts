// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях. [3, 7, 23, 12] -> 19  [-4, -6, 89, 6] -> 0

int[] InitArray(int length)
{
    int[] resultArray = new int[length];
    Random rnd = new Random{};

    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = rnd.Next(-10, 10);
    }
    return resultArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]} ");
    }
    Console.WriteLine();
}

int GetNumbers(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}
int GetOddInxElmntSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i=i+2)
    {
        sum = sum + array[i];
    }
    return sum;
}

int length = GetNumbers("Введите размерность массива");
int[] arr = InitArray(length);
PrintArray(arr);
int oddinxsum =  GetOddInxElmntSum(arr);
Console.WriteLine($"Сумма элеменетов с нечетными индексами: {oddinxsum}");
