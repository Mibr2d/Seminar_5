// Задача 2: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, стоящих 
// на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 6] -> 0


int[] GenerateArray(int len)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 99);
    }
    return array;
}


int oddNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            count +=array[i];
        }
    }
    return count;

}
void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item}\t");
    }
    System.Console.WriteLine();
}
int[] array = GenerateArray(5);
PrintArray(array);
int count=oddNumber(array);
System.Console.WriteLine($"Сумма чисел на нечетных позициях {oddNumber(array)}");