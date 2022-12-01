//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

Console.WriteLine("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
int sum = 0;

int[
    
] GetArray(int[] array)
{
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
int GetCount(int [] array)
{
   for (int i = 0; i < n; i++)
   {
    if (array[i] % 2 == 0) sum++;
   } 
    return sum;
}

GetArray(array);
Console.WriteLine(string.Join(",", array));
Console.WriteLine("Количество четных чисел:" + GetCount(array));


