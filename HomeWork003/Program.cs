// Задача 3: Задайте массив вещественных чисел. Найдите 
// разницу между максимальным и минимальным 
// элементов массива.
// [3, 7.4, 22.3, 2, 78] -> 76


double[] GenerateArray(int len)
{
    double[] array = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next();
    }
    return array;
}
double Maximum(double[] array)
{
    double maxValue = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (maxValue < array[i])
        {
            maxValue = array[i];

        }

    }
    return maxValue;
}
double Minimum(double[] array)
{
    double minValue = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (minValue > array[i])
        {
            minValue = array[i];

        }

    }
    return minValue;
}

void PrintArray(double[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item}\t");
    }
    System.Console.WriteLine();
}
double[] array = GenerateArray(3);
PrintArray(array);
double maxValue = Maximum(array);
double minValue = Minimum(array);
double defference = maxValue - minValue;
System.Console.WriteLine($"Максимальное число {maxValue}, Минимальное число {minValue}, Разность между максимальным и минимальным {defference}");





