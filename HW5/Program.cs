// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0


Console.Write("Введите количество элементов в массиве: ");
int length = int.Parse(Console.ReadLine());
int[] array = new int[length];
Random rnd = new Random();
int sum = 0;
for (int i = 0; i < length; i++)
{
    array[i] = rnd.Next(1, 10);
    System.Console.Write($" [{array[i]}] ");
    if (i % 2 != 0)
    {
        sum += array[i];
    }
}
System.Console.WriteLine();
System.Console.WriteLine($"Сумма нечетных элементов массива равна {sum}");
