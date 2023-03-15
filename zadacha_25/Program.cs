// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

int Power(int number, int degree) 
 { 
     int result = 1; 

     for(int i = 1; i <= degree; i++) 
     { 
         result = result * number; 
     } 
     return result; 
 } 

Console.Write("Введите число А :  ");
 int A = Convert.ToInt32(Console.ReadLine()); 
 Console.Write("Введите число B :  "); 
 int B = Convert.ToInt32(Console.ReadLine()); 

 Console.Write($"Итого: {Power(A, B)}");




 

