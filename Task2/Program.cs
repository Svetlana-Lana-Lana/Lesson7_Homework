// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int CalculateAckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return CalculateAckermannFunction(m - 1, 1);
    }
    else
    {
        return CalculateAckermannFunction(m - 1, CalculateAckermannFunction(m, n - 1));
    }
}

Console.WriteLine("Введите неотрицательное число m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число n ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CalculateAckermannFunction(m, n));
