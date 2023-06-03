Console.Clear();
Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите число: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 0; i < B; i++)
result *= A;
Console.WriteLine("Результат: " + result);