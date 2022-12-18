// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M");
var m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N");
var n = int.Parse(Console.ReadLine());

Console.WriteLine($"M = {m}; N = {n} -> {Sum(m,n,0)}");

int Sum(int m, int n, int res){
    if (m <= n){
        return Sum(m+1, n , res+m);
    }

    return res;
}
