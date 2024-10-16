﻿// See https://aka.ms/new-console-template for more information
public class Exercise_02
{
    public static void Main()
    {
        //question_01();
        //question_02();
        question_03();
        Console.ReadKey();
    }
    public static void question_01()
    {
        //To convert from degrees Celsius to Kevin and Fahrenheit
        Console.Write("Nhap vao do C: ");
        float doC = float.Parse(Console.ReadLine());
        float doK = doC + 273;
        float doF = doC * 18 / 10 + 32;
        int C = (int)doF;
        Console.WriteLine($" Do C ban vua nhap vao la {doC}");
        Console.WriteLine($"Kelvin = {doK}");
        Console.WriteLine($"Fahrenheit = {C}");
    }
    public static void question_02()
    {
        //Calculate the surface and volume of a sphere
        Console.Write("Nhap vao ban kinh: ");
        double r = double.Parse(Console.ReadLine());
        double  surface = 4 * Math.PI * r * r;
        double volume = 4 / 3 * Math.PI * r * r * r ;
        Console.WriteLine($" Surface: {surface}");
        Console.WriteLine($" Volume: {volume}");
    }
    public static void question_03()
    {
        //Calculates the result of adding, subtracting, multiplying and dividing two numbers
        Console.Write("Nhap so a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhap so b: ");
        int b = int.Parse(Console.ReadLine());
        int sum = a + b;
        int subtract = a - b;
        int multiply = a * b;
        int divide = a / b;
        int mod = a % b;
        Console.WriteLine($" {a} + {b} = {sum}");
        Console.WriteLine($" {a} - {b} = {subtract}");
        Console.WriteLine($" {a} x {b} = {multiply}");
        Console.WriteLine($" {a} / {b} = {divide}");
        Console.WriteLine($" {a} mod {b} = {mod}");
    }
}
