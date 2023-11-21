//  Задайте значения M и N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.
Console.WriteLine("Введите натуральное первое число!");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное второе число!");
int num1 = Convert.ToInt32(Console.ReadLine());

void Function(int num)
{
    if(num1 > 0)
    {
        if(num > num1)
    {
        return ;
    }
    if(num > 0) Console.Write($"{num}"+ " ");
    num = num + 1;
    Function(num);
    }
    else Console.WriteLine("Введите второе число больше ноля!");
    
} 
Function(num);