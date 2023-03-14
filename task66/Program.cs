// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();
int M = InputInt("Enter M:");
int N = InputInt("Enter N:");
Console.WriteLine($"Sum of elements from {M} to {N} = {Sum(M, N)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int Sum(int M, int N)
{
    if (M == N)
        return N;
    return N + Sum(M, N - 1);
}