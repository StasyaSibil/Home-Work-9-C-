//  Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// M = 5; N = 3 -> "5, 4, 3"
// M = 8; N = 4. -> "8, 7, 6, 5, 4"

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
NaturalNumbers(n, 1);


void NaturalNumbers(int max, int num)
{
    if (num > max)
    {
        return;
    }
    
    NaturalNumbers(n, num + 1);
    Console.Write(num+",");
}