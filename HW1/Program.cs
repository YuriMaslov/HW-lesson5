// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt()
{
    System.Console.WriteLine(" Введите число: ");
    int num = int.Parse(System.Console.ReadLine());
    return num;
}
int GetSum(int number)
{
    int num = 0;
    while (number > 0)
    {
        num += number % 10;
        number = number / 10;
    }
    return num;
}
int number = Prompt();
System.Console.WriteLine($" Сумма чисел {number} равна {GetSum(number)}");
