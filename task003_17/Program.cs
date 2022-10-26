//17. Напишите программу, которая принимает на вход координаты точки (X и Y),
//причем X не равен 0 и Y не равен 0 и выдает номер четверти плоскости, в которой
//находится эта точка.
Console.Clear();
void Proverka0(double z, string number)
{
    if (z == 0) Console.WriteLine($"Число {number} равно 0, введите числа не равные 0");
}
Console.Write("Введите пожалуйста координату X не равную 0: ");
double numX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите пожалуйста координату Y не равную 0: ");
double numY = Convert.ToInt32(Console.ReadLine());
Proverka0(numX, "X");
Proverka0(numY, "Y");
if ((numX > 0) & (numY > 0)) Console.WriteLine("Четверть №1");
if ((numX < 0) & (numY > 0)) Console.WriteLine("Четверть №2");
if ((numX < 0) & (numY < 0)) Console.WriteLine("Четверть №3");
if ((numX > 0) & (numY < 0)) Console.WriteLine("Четверть №4");