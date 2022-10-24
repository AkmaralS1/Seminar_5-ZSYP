// Task 31.Задайте массив из 12 элементов заполненный случайными
// числами из промежутка [-9, 9]. Найдите сумму отрицательных и 
// и положительных элементов массива.
// Например в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6]
// сумма положительных чисел равно 29 сумма отрицат равно -20

void InputArray(int[] array)  // - это заполнение массива случайным образом
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}

int SummaPositiveNumbers(int[] array) // - это нахождение суммы положит чисел
{
    int summaP = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            summaP = summaP + array[i]; // summaP += array[i];
    }
    return summaP;
}

int SummaNegativeNumbers(int[] array) // - это нахождение суммы отриц чисел
{
    int summaN = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            summaN = summaN + array[i]; // summaN += array[i];
    }
    return summaN;
}

Console.Clear();
int[] array = new int[12];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Сумма положительных элементов равна: {SummaPositiveNumbers(array)}");
Console.WriteLine($"Сумма отрицательных элементов равна: {SummaNegativeNumbers(array)}");