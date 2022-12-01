//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

Console.WriteLine("Введите количество элементов массива  ");
int n = Convert.ToInt32(Console.ReadLine());

int max = Int32.MinValue;
int min = Int32.MaxValue;

int[] array = new int[n];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);
}

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}

int res = max - min;

Console.WriteLine(string.Join(",", array));
Console.WriteLine("Максимальное число в массиве: " + max);
Console.WriteLine("Минимальное число в массиве: " + min);
//Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + (max - min));
Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + res);