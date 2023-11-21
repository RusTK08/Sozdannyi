
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// Указание
// Использовать рекурсию. Не использовать цикл.


// Пример

// N=5 => 1 2 3 4 5
int number = Convert.ToInt32(Console.ReadLine());

void Function(int number)
{
    if(1 == number)
    {return ;}

    number =  number - 1; 
    Function(number);

    Console.WriteLine(number);
}

Function(number);


Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите возведение в степень");
int numberB = Convert.ToInt32(Console.ReadLine());


int Function(int numberA, int numberB)
{
    if(1 == numberB)
    {return numberA;}
    return numberA * Function(numberA, numberB - 1);
}
//  Function( numberA, numberB);
Console.Write("Итог = ");
Console.WriteLine(Function(numberA, numberB));
