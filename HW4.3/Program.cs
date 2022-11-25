// Напишите программу, которая задаёт массив из N элементов и выводит их на экран. Вывод сделать отдельным методом//

Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[size];

for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next();
    Console.Write(numbers[i] + " ");
}

// не совсем поняла, что значит сделать вывод отдельным методом