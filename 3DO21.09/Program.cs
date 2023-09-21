Console.WriteLine("Введите координату центра окружности a: ");
string input = Console.ReadLine();
if (int.TryParse(input, out int a))
{
    Console.WriteLine("Введите координату центра окружности b: ");
    input = Console.ReadLine();
    if (int.TryParse(input, out int b))
    {
        Console.WriteLine("Введите радиус окружности: ");
        input = Console.ReadLine();
        if (int.TryParse(input, out int r))
        {
            Console.WriteLine($"Координаты цента окружности: ({a};{b})");
            Console.WriteLine($"Радиус окружности: {r}");
            Console.WriteLine($"(x - {a})^2 + (y - {b})^2 = {Math.Pow(r,2)}");
        }
        else
        {
            Console.WriteLine("Вы ввели не число");
        }

    }
    else
    {
        Console.WriteLine("Вы ввели не число");
    }
}
else
{
    Console.WriteLine("Вы ввели не число");
}