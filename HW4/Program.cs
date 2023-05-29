// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] GetArray(int size, int minValue, int maxValue) // это метод, с помощью которого можно создавать любой размерности массив и с любым диапазоном
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1); // к maxValue мы прибавляем 1, чтобы включить именно 9-ку, т.к. диапазон от -9 до 9
        System.Console.Write($"{arr[i]} ");
    }
    return arr;
}

void CheckNumArr(int[] arr, int userNumMax, int userNumMin)
{
    int sum = 0;
    foreach (int el in arr)
    {
        if (el % 2 == 0)
        {
            sum++;
        }
    }
    System.Console.WriteLine(
        $" Количество четных элементов массива от {userNumMin} до {userNumMax} равно {sum} "
    );
}
int[] array = GetArray(5, 100, 1000);
CheckNumArr(array, 1000, 100);
