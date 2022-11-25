// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B//

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = Convert.ToInt32(Math.Pow(numberA, numberB));

Console.WriteLine($"Число {numberA} в натуральной степени {numberB} равно {result}");