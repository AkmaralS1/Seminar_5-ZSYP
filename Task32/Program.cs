// Task 32 Напишите программу замена элементов массива 
// положительные элементы замените на соответствующие 
// отрицательне и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2]

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10);
// }

// void ReleaseArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = array [i] * (-1);
// }

// Console.Clear();
// Console.Write("введите колличество элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// ReleaseArray(array);
// Console.WriteLine($"конечный массив: [{string.Join(", ", array)}]");



// Task 33 Задайте массив. Напишите прорамму которая определяет 
// присутствует ли заданное число в массиве
// 4 массив [6,7,19,345,3] -> нет; 3 массив [6,7,19,345,3] -> да

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}
string ReleaseArray(int[] array, int number)
{
    for (int i = 0; i< array.Length; i++)
    {
        if (array[i] == number)
            return "yes";
    }
    return "no";
}
Console.Clear();
Console.Write("введите колличество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.Write("Введите число которе вы хотите найти: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"{ReleaseArray(array, m)}");
