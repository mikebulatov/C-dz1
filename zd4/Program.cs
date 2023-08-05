// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача 4: Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
int num1,num2,num3,max;
Console.Write("Введите 1е число:");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2е число:");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3е число:");
num3 = Convert.ToInt32(Console.ReadLine());
max=num1;
if(max<num2)
    {
    max=num2;
    }

if(max<num3)
    {
    max=num3;
    }

 
Console.Write("Максимум из 3х чисел:");
Console.WriteLine(max);
 