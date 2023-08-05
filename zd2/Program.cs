// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача 2: Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее");
int num1,num2;
Console.Write("Введите 1е число:");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2е число:");
num2 = Convert.ToInt32(Console.ReadLine());
if(num1==num2)

{
    Console.WriteLine("числа равны");
    }
else
{

    if(num1>num2)
    {
        Console.WriteLine("1е число больше 2го");
    }
    else
    {
        Console.WriteLine("2е число больше 1го");
    }
}