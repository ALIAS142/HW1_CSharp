// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Enter number one :");
string strNumberOne = Console.ReadLine();
int NumberA = Convert.ToInt32(strNumberOne);

Console.WriteLine("Enter number two :");
string strNumberTwo = Console.ReadLine();
int NumberB = Convert.ToInt32(strNumberTwo);

int max = NumberA;

     if (NumberA > max) max = NumberA; 
     
     if (NumberB > max) max = NumberB; 

        Console.Write("max = ", "min =");
      
        Console.WriteLine(max);
