// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

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
int FindSum(int [] array)
{
     int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        {
             sum += array[i];
        }
    }
    return sum;
}
int [] array = CreateArray(10, 1, 10);
PrintArray(array);
Console.WriteLine();
int sum = FindSum(array);
Console.WriteLine ($"Сума элементов, стоящих на нечетных позициях = {sum}");
