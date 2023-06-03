Console.Clear();
Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine()!);
    int sum = 0;
    int myInt  = number;
while (myInt != 0)
{
    int digit = myInt % 10;
    sum += digit;
    myInt /= 10;
}
Console.WriteLine("Сумма цифр числа: " + sum);