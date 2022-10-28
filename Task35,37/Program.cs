// Task 35. Задайте одномерный массив из 123 случайных чисел 
// из промежутка [-100, 100]. Найдите колличество элементов массива, 
// значения которых лежат в отрезке [10, 99].
// Например [10,11,12,13,14] -> 5

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-100, 100);
// }
// int ReleaseArray(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 10 && array[i] <= 99)
//             count++;
//     }
//     return count;
// }
// Console.Clear();
// Console.Write("Введите ко-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.Write(ReleaseArray(array));



// Task 37. Найдите произведение пар чисел в одномерном массиве 
// Парой считаем первый и последний элемент второй и предпоследний и тд.
// Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 9

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 6);
}

void ReleaseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
    {   
        Console.Write($"{array[i] * array[array.Length - i - 1]} ");
    }
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальнаый массив: [{string.Join(", ", array)}]");
ReleaseArray(array);