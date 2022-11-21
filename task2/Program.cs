int aX = ReadInt("Введите координату X точки А: ");
int aY = ReadInt("Введите координату Y точки А: ");
int aZ = ReadInt("Введите координату Z точки A: ");
int bX = ReadInt("Введите координату X точки B: ");
int bY = ReadInt("Введите координату Y точки B: ");
int bZ = ReadInt("Введите координату Z точки B: ");

int sqrSideX = (aX - bX) * (aX - bX);
int sqrSideY = (aY - bY) * (aY - bY);
int sqrSideZ = (aZ - bZ) * (aZ - bZ);
double distance = Math.Sqrt(sqrSideX + sqrSideY + sqrSideZ);
Console.WriteLine(distance);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
