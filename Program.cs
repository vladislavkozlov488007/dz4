// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
System.Console.WriteLine("Введите 8 чисел с клавиатуры");
int[] array = new int[8];
for (int i=0; i<8; i++)
array[i] = Convert.ToInt32(Console.ReadLine());
PrintArray(array);

void PrintArray(int[] a)
{
    for (int i=0; i<a.Length-1; i++)
    System.Console.Write($"{a[i]}, ");
    System.Console.WriteLine($"{a[^1]}");
}