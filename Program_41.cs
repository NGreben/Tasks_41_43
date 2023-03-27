/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
int M;
Console.Write($"Введите размер массива: ");
int.TryParse(Console.ReadLine()!, out M);

int[] array = new int[M];
for (int i = 0; i < M; i++)
{
    Console.Write($"Введите {i + 1}-е число: ");
    int.TryParse(Console.ReadLine()!, out array[i]);
}

Console.Write($"-> {CountPositiveNumb(array)} - введено чисел больше 0");

int CountPositiveNumb(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0)
            count++;
    return count;
}