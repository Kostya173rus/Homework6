// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
int InPutNum(string message) // ввод данных
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double firstfunction(double num1, double num2, double num3, double num4)
{
    double result1 = (-1 * (num1 - num2) / (num3 - num4));
    return result1;
}
double secondfunction(double num1, double num2, double num3, double num4)
{
    double result2 = (num3 * (-1 * (num1 - num2) / (num3 - num4))) + num1;
    return result2;
}
double b1 = InPutNum("Введите число b1: ");
double k1 = InPutNum("Введите число k1: ");
double b2 = InPutNum("Введите число b2: ");
double k2 = InPutNum("Введите число k2: ");
double x = firstfunction(b1, b2, k1, k2);
double y = secondfunction(b1, b2, k1, k2);
Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}, Y: {y}");