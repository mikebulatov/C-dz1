// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача 6: Программа, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
int num,num2;
Console.Write("Введите  число:");
num = Convert.ToInt32(Console.ReadLine());

if(num%2>0)

{
    Console.WriteLine("Число не четное");
}
else
{

    Console.WriteLine("Число четное");

}