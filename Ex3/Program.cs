// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double [] CreateArray(int length)
{
    double [] array = new double [length];
    for (int i = 0; i < length; i++)
    {
        array [i] = new Random().NextDouble()*40-20;
    }
    return array;
}
void PrintArray(double[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
double FindMax(double [] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array [i] > max)
        {
             max = array[i];
        }
    }
    return max;
}
double FindMin(double [] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array [i] < min)
        {
             min = array[i];
        }
    }
    return min;
}
double [] array = CreateArray(10);
PrintArray(array);
Console.WriteLine();

double max = FindMax(array);
Console.WriteLine ($"Максимальный элемент массива = {max}");

double min = FindMin(array);
Console.WriteLine ($"Минимальный элемент массива = {min}");

double diff = max - min;
Console.WriteLine ($"Разница между максимальным и минимальным элементами массива = {diff}");
