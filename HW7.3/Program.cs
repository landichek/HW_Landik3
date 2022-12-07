// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
int[] summ = new int[columns];
FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);

int firstIndex = 0;
int secondIndex = numbers.GetLength(0) - 1;

for(int i = 0; i < numbers.GetLength(1); i++)
{
    Console.Write(numbers[rows, columns]);
    summ[i] += numbers[rows, columns];
}
WriteMatrix(numbers);

void FillMatrixRandomNumbers(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}



void WriteMatrix(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
            foreach (double elem in summ)
            {
                
                Console.WriteLine(elem/columns);
            }

//Не дорешала. Я очень усталь. Пусть останется так. Сорри)))