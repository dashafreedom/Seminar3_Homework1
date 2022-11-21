string number = ReadInt("Введите пятизначное число: ");


if(number[0] == number[4] && number[1] == number[3])
{
    Console.WriteLine("Да");
}
else if(number.Length > 5)
{
    Console.WriteLine("Это число не пятизначное!");
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
