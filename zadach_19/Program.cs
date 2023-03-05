// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

 System.Console.WriteLine("Введите  число: ");

int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string str = Convert.ToString(number);

 int[] arrayPolindrome = new int[5];
 
for (int i = 0; i < arrayPolindrome.Length; i++)
 {
    arrayPolindrome[i] = Convert.ToInt32(Console.ReadLine());
 }

 if (arrayPolindrome[0] == arrayPolindrome[4] && arrayPolindrome[1] == arrayPolindrome[3])
{
 Console.Write("палиндром");
 }
else
{
   Console.Write("НЕ палиндром");
}
 Console.ReadLine();



// int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
	// string str = Convert.ToString(number);
	// //int result = Convert.ToInt32(str.Length);