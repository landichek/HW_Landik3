// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве//


int aX = ReadInt("Введите координату Х точки А: ");
int aY = ReadInt("Введите координату У точки А: ");
int aZ = ReadInt("Введите координату Z точки А: ");
int bX = ReadInt("Введите координату Х точки B: ");
int bY = ReadInt("Введите координату У точки B: ");
int bZ = ReadInt("Введите координату Z точки B: ");

int sqrSideX = (aX-bX) * (aX- bX);
int sqrSideY = (aY-bY) * (aY- bY);
int sqrSideZ = (aZ-bZ) * (aZ- bZ);
Double distance = Math.Sqrt(sqrSideX+sqrSideY + sqrSideZ);
Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

