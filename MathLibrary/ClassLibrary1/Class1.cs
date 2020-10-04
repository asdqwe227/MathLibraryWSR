using System;

namespace MathLibrary
{
    public class Math
    {
        const double PI = 3.14;
        public static double Addition(double a, double b) => a + b;
        public static double Substract(double a, double b) => a - b;
        public static double Multiplay(double a, double b) => a * b;
        public static double Split(double a, double b) => a / b;
        public static double Circle_S(double r) => PI * r * r;
        public static double Square_S (double a, double b) => a * b;
        public static double Parallelogram_S(double a, double h) => a * h;
    }
}
