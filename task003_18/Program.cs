﻿//18. Напишите программу, которая по заданному номеру четверти, показывает диапазон
//возможных координат точек в этой четверти (X и Y).
//=================================================================================
Console.Clear();
void Examination(double z)
{
    if (z <= 1) Console.WriteLine($"Введенное число меньше 1");
    if (z >= 4) Console.WriteLine($"Введенное число больше 4");
}
Console.Write("Введите пожалуйста номер четверти, число должно быть от 1 до 4: ");
double num = Convert.ToInt32(Console.ReadLine());
Examination(num);
if (num == 1) Console.Write($"Диапазон от нуля до +бесконечности по X и Y");
if (num == 2) Console.Write($"Диапазон от нуля до -бесконечности по X и до +бесконечности по Y");
if (num == 3) Console.Write($"Диапазон от нуля до -бесконечности по X и Y");
if (num == 4) Console.Write($"Диапазон от нуля до +бесконечности по X и до -бесконечности по Y");