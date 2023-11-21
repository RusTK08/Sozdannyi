//Задайте произвольный массив. Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.
Console.WriteLine("Введите числа через ,");
string  stroka = Console.ReadLine();
string [] array = stroka.Split(",");

int i = 0;
void Vivod(string [] array)
{
    
    if(i == array.Length) 
    {return ;}
    Console.Write($"{array [i]}" + " ");
    i = i + 1;
    Vivod(array);
    
}
Vivod(array);