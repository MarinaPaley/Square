using System;
using SquareLibrary;

public class Program
{
    private static void Main(string[] args)
    {
        var square = new Square(1);
        Console.WriteLine($"Сторона квадрата = {square}");
    }
}