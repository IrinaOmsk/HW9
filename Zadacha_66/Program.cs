// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. Рекурсивно

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Введите M ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n)
    Console.WriteLine("Введен некорректный промежуток");
else
    Console.WriteLine(SummNaturalElements(m, n));

int SummNaturalElements(int m, int n, int summ = 0)
{
    if (m > n)
    {
        return summ;
    }
    summ = summ + n;
    return SummNaturalElements(m, n - 1, summ);
}

