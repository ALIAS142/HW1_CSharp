// See https://aka.ms/new-console-template for more information


Console.WriteLine("Enter number :");

int numberN = Convert.ToInt32(Console.ReadLine());

int numberK = 2;

if (numberN == 1 || numberK <= 0)
{
    Console.WriteLine("Wrong number");
}
else
{
    Console.Write(numberN+" ->");
    while (numberK<=numberN)
    {
        Console.Write(numberK+" ");
        numberK += 2;
    }
}
