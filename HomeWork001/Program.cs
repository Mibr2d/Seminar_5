// Задача 1: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите 
// программу, которая покажет количество чётных чисел в 
// массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateArray(int len)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 999);
    }
    return array;
}
int EvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count +=1;
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
int[] array = GenerateArray(8);
PrintArray(array);
int count=EvenNumber(array);
System.Console.WriteLine($"Количество четных чисел в массиве {EvenNumber(array)}");