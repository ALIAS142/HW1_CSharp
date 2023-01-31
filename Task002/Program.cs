// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Enter number one : ");
string strNumberA = Console.ReadLine();
int NumberA = Convert.ToInt32(strNumberA);

Console.WriteLine("Enter number two : ");
string strNumberB = Console.ReadLine();
int NumberB = Convert.ToInt32(strNumberB);

Console.WriteLine("Enter number three : ");
string strNumberC = Console.ReadLine();
int NumberC = Convert.ToInt32(strNumberC);

int max = NumberA;

     if (NumberB > max) max = NumberB;
     if (NumberC > max) max = NumberC;
     
     Console.WriteLine(max);
  