// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

using System;
using static System.Console;

Clear();

WriteLine("Введите значение b1: ");
double b1 = double.Parse(ReadLine());
WriteLine("Введите значение k1: ");
double k1 = double.Parse(ReadLine());
WriteLine("Введите значение b2: ");
double b2 = double.Parse(ReadLine());
WriteLine("Введите значение k2: ");
double k2 = double.Parse(ReadLine());
WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({CrossingTwoLines(b1, k1, b2, k2)})");

string CrossingTwoLines(double number1, double number11, double number2, double number22)
{
    string crossing = "";
    double x = (number2 - number1)/ (number11 - number22);
    double y = number11 * x + number1;
    crossing = $"{x}; {y}";
    return crossing;
}