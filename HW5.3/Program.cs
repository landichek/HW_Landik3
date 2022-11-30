// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива//


            int[] arr = new int[5];
            int delta = 0, i;
            Random rand = new Random();
            Console.WriteLine("Исходный массив");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 50);
                Console.Write(arr[i] + " ");
            }
  Console.WriteLine();
            var min = arr[0];
            var max = arr[0];
 
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                else if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            for (i = 0; i < arr.Length; i++)
            {
                delta = max - min;
            }
            Console.WriteLine("Минимальный элемент: " + min);
            Console.WriteLine("Максимальный элемент: " + max);
            Console.WriteLine("Разница между максимальным и минимальным числом массива равна: " + delta);
          
