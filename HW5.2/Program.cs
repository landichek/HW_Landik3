// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях// 

  int[] arr = new int[5];
            int sum = 0;
            Random rnd = new Random();
 
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(100, 999);
               Console.Write(arr[i] + " ");
            }
        for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 > 0)
                {
                    sum += arr [i];
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях равна {sum}");
