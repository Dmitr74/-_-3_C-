// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();


Console.Write("Введите число А :  ");
double A = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число B :  ");
double B = Convert.ToDouble(Console.ReadLine());

double result = Math.Pow(A, B);

Console.Write($"Длина вашего числа: {result}");


