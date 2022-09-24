int number = ReadInt("Введите число: ");
int result = 0;
while (number > 0)
{
    result += number % 10;
    number = number / 10;
}

Console.Write(result);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}