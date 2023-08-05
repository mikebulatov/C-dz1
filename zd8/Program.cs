// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача 8: Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
int i,N;
Console.Write("Введите  число:");
N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Четные числа:");
for(i=1;i<=N;i++){
if(i%2==0)
    {
    Console.Write(i);
    Console.Write(", ");
    }
}