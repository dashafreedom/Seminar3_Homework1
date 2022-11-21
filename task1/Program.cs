string number = ReadInt("Введите пятизначное число: ");

if(number[0] == number[4] && number[1] == number[3])
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

string ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToString(Console.ReadLine());
}
