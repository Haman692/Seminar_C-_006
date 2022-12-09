// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

void ToBinarySystem(int num)
{
    if(num <= 0)
    {
        return;
    }
    ToBinarySystem(num/2);
    System.Console.Write(num%2);
}


System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
ToBinarySystem(number);
