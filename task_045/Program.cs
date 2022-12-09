//  Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.



System.Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());



int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1); // [-9; 10)
    }
    return arr;
}


int[] array = FillArrayWithRandomNumbers(N, 1, 10);
Console.WriteLine('[' + string.Join(", ", array) + ']');
int[] array2 = new int [N];
for (int i = 0; i < N; i++)
{
    array2[i] = array[i];
}

Console.WriteLine('[' + string.Join(", ", array2) + ']');
