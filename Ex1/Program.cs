//  Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int [] CreateArray(int length, int min, int max)
{
    int [] array = new int [length];
    for (int i = 0; i < length; i++)
    {
        array [i] = new Random().Next(min, max+1);
    }
    return array;
}
void PrintArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
int FindCount(int [] array)
{
     int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
             count++;
        }
    }
    return count;
}
int [] array = CreateArray(10, 99, 1000);
PrintArray(array);
Console.WriteLine();
int count = FindCount(array);
Console.WriteLine ($"Количество четных чисел в массиве = {count}");