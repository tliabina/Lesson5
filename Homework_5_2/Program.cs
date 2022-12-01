//Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

int[] GetArray(int n)
{
    int[] array = new int[n];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-50, 100);
    }
    return array;
}

int GetSum(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum = sum + array[i];

    }

    return sum;
}


Console.WriteLine("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = GetArray(n);
int sum = GetSum(array);
Console.WriteLine(string.Join(",", array));
Console.WriteLine("Сумма элементов, стоящих на нечетных позициях: " + sum);
