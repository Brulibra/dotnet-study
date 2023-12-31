using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_study.Models
{
    public class Calculator
    {
        public void Sum(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtraction(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiplication(int x, int y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");
        }
        public void Divison(int x, int y)
        {
            Console.WriteLine($"{x} ÷ {y} = {x / y}");
        }
        public void Power(int x, int y)
        {
            double power = Math.Pow(x, y);
            Console.WriteLine($"{x} ˆ {y} = {power}");
        }
        public void Sin(double angle)
        {
            double radiangle = angle * Math.PI / 180;
            double sin = Math.Sin(radiangle);
            Console.WriteLine($"Seno de {angle} = {Math.Round(sin, 2)}");
        }
        public void Cos(double angle)
        {
            double radiangle = angle * Math.PI / 180;
            double cos = Math.Cos(radiangle);
            Console.WriteLine($"Coseno de {angle} = {Math.Round(cos, 2)}");
        }
        public void Tangent(double angle)
        {
            double radiangle = angle * Math.PI / 180;
            double tangent = Math.Tan(radiangle);
            Console.WriteLine($"Coseno de {angle} = {Math.Round(tangent, 2)}");
        }
        public void SquareRoot(double x)
        {
            double squarRoot = Math.Sqrt(x);
            Console.WriteLine($"Raiz Quadrada de {x} = {squarRoot}");
        }
    }
}