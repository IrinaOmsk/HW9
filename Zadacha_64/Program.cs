// Задача 64: Задайте значение N. 
//Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
DesSeqOfNumber(n);

void DesSeqOfNumber(int n)
{
    if (n <= 0)
    {
        Console.WriteLine();
        return;
    }
    Console.Write($"{n} ");
    DesSeqOfNumber(n - 1);
}



