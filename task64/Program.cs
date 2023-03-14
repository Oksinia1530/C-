// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();

int N = InputInt("Enter the number");
int M = 1;
if (N < 1)
{
    Console.WriteLine("Enter a positive number");
}
Console.WriteLine(Number(N, M));

int Number(int N, int M)
{
    if (N == M)
        return N; 
    else
        Console.Write($"{Number(N, M + 1)}, ");
    return M;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}