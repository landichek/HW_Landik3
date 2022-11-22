// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N//

int number = ReadInt("Введите число: ");
int i = 1;
while(i <= number)
{
    Console.Write(Pow(i++) + " ");
}

int Pow(int a)
{
    return a * a * a;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
