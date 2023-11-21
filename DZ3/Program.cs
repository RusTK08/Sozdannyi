//Задайте произвольный массив. Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.
Console.WriteLine("Введите числа через ,");
string  stroka = Console.ReadLine();
string [] array = stroka.Split(",");
void Vivod(string [] array)
{
    int i = 0;
    if(i > array.Length)
    return ;
    i = i + 1;
    Console.Write($"{array [i]} ");
    Vivod(array);
}
Vivod(array);