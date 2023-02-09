// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
try
{
    Console.WriteLine("Введите число А:");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B:");
    int b = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine($"Число А в степени В равно: {degree(a, b)}");
    

    int degree(int a, int b)
    {
        int result = 1;
        for (int i = 1; i <= b; i++) result = result * a;
        return result;
    }
}

catch
{
    System.Console.WriteLine("Надо было вводить целое число");
}
