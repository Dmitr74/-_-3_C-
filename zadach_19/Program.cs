// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();


Console.WriteLine("Введите  число: ");
string str = Console.ReadLine();
int n = Math.Abs(Convert.ToInt32(str));

int[] arrayPolindrome = new int [n];  //new int[]
//int n = arrayPolindrome.Length;


for (int i = 0; i < arrayPolindrome.Length; i++)
 {
    arrayPolindrome[i] = arrayPolindrome[i] + n; 
 
    if (arrayPolindrome[0] == arrayPolindrome[4] && arrayPolindrome[1] == arrayPolindrome[3])
   {
   Console.Write("палиндром ");
   }
   else
   {
      Console.Write("НЕ палиндром ");
   }

 }
