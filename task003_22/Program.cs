//22. Напишите программу, которая принимает на вход число (N) и выдает таблицу
//квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4
//================================================================================
Console.Clear();
Console.Write("Введите пожалуйста число: ");
double N = Convert.ToInt32(Console.ReadLine());
Console.Write($"{N} -> ");
for (int i = 1; i <= N; i++)
{
    if (i < N)
    {
        double result = Math.Pow(i, 2);
        Console.Write($"{result}, ");
    }
    else 
    {
        double result = Math.Pow(i, 2);
        Console.Write(result);
    }
}