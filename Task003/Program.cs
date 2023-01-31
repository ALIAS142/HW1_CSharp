// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Enter number :");

string strNumber = Console.ReadLine();

int Number1 = Convert.ToInt32(strNumber);


if (Number1%2 == 0)
{
    Console.WriteLine ("Integer number");
}
else {
    Console.WriteLine ("Odd Integer number");   
}