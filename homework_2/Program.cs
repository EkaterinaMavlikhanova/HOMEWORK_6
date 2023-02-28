/*  Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
*/ 


int GetNumber(string message)
{
int result = 0;

while (true)
{
    Console.WriteLine(message);
    
    if (int.TryParse(Console.ReadLine(), out result))
    {
        break;
    }
    else
    {
        Console.WriteLine("Ввели не число или 0. Повторите ввод");
    }
}

return result;
}

int k1 = GetNumber("Введите координату k1: ");
int b1 = GetNumber("Введите координату b1: ");

int k2 = GetNumber("Введите координату k2: ");
int b2 = GetNumber("Введите координату b2: ");



double IntersectionPoint (int k1, int b1, int k2, int b2)
{
    double resultX = Math.Sqrt(Math.Pow(b1 - b2) / Math.Pow(k1 - k2));
    return resultX;
}

double IntersectionPoint ()
{
    double resultY = Math.Sqrt(Math.Pow (k1 * (b2-b1)) / Math.Pow(k1-k2) + b1);
    return resultY;
}

Console.WriteLine($"Пересечение в точке: ({resultX};{resultY})");
