// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N (использовать рекурсию)

void AllNaturalNumbers(int first, int last)
{
    if (first > last)
    {
        return;
    }
    Console.Write(first + " ");
    AllNaturalNumbers(first + 1, last);
    

}

Console.WriteLine("Enter first number ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter last number ");
int last = Convert.ToInt32(Console.ReadLine());

AllNaturalNumbers(first, last);
