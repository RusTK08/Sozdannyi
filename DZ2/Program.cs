//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
Console.WriteLine("Введите число M");
int NumberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int NumberN = Convert.ToInt32(Console.ReadLine());
void Proverka(int NumberM, int NumberN)
{
if(NumberM > 0) return ;
else if(NumberN > 0) return ;
else Console.WriteLine("Введите положительные целые числа!");
}
Proverka(NumberM, NumberN);
int Akkerman(int NumberM, int NumberN)
{
    
    if(NumberM == 0) return NumberN + 1;
    
    else if(NumberN == 0) return Akkerman(NumberM - 1, 1);
    
    else return Akkerman(NumberM - 1, Akkerman(NumberM, NumberN - 1));
}

Console.Write(Akkerman(NumberM, NumberN));
// Console.Write("Введите значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int Akkerman(int m, int n)
// {
// if (m == 0) return n + 1;
// else if (n == 0) return Akkerman(m - 1, 1);
// else return Akkerman(m - 1, Akkerman(m, n - 1));
// }

// Console.Write($"Функция Аккермана равно {Akkerman(m, n)} ");