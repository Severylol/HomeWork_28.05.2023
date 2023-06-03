Console.Clear();
int[] array = new int[8];
Console.WriteLine("Введите 8 элементов массива: ");
for (int i = 0; i < array.Length; i++)
{
Console.Write("Элемент " + (i + 1) + ": ");
array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Элементы массива:");
for (int i = 0; i < array.Length; i++)
{
Console.WriteLine("Элемент " + (i + 1) + ": " + array[i]);
}