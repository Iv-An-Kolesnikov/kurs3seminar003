//18. Напишите программу, которая по заданному номеру четверти, показывает диапазон
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
double numX = 9999;
double numY = 9999;
if (num == 1) Console.Write($"Диапазон от X={numX} до Y={numY}");
if (num == 2) Console.Write($"Диапазон от X={numX * (-1)} до Y={numY}");
if (num == 3) Console.Write($"Диапазон от X={numX * (-1)} до Y={numY * (-1)}");
if (num == 4) Console.Write($"Диапазон от X={numX} до Y={numY * (-1)}");