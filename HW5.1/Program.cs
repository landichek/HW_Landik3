// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве//

  int[] arr = new int[5];
            int k = 0;
            Random rnd = new Random();
 
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < 5; i++)
            {
                arr[i] = rnd.Next(100, 999);
                
            }
        foreach(int element in arr)
            {
                Console.Write("{0} ", element);
                if (element % 2 == 0)
                {
                    k++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Число четных элементов равно {k}");
