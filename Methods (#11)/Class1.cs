using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Methods___11_
{
    static class MyMethods
    {
        /// <summary>
        /// Gets the hypotenuse of a triangle
        /// </summary>
        /// <param name="a">The length of side one</param>
        /// <param name="b">The length of side two</param>
        /// <returns>The hypotenuse</returns>
        public static double GetHypotenuse(double a, double b)
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
        /// <summary>
        /// Determines the distance between two Y values on a graph
        /// </summary>
        /// <param name="y1">The first Y coordinate</param>
        /// <param name="y2">The second Y coordinate</param>
        /// <returns></returns>
        public static double GetRise(double y1, double y2)
        {
            return y2 - y1;
        }
        /// <summary>
        /// Determines the distance between two Y values on a graph
        /// </summary>
        /// <param name="p1">Point 1</param>
        /// <param name="p2">Point 2</param>
        /// <returns>The distance</returns>
        public static double GetRise(Point p1, Point p2)
        {
            return GetRise(p1.Y, p2.Y);
        }
        /// <summary>
        /// Determine the distance between two X values on a graph
        /// </summary>
        /// <param name="x1">The first X coordinate</param>
        /// <param name="x2">The second X coordinate</param>
        /// <returns></returns>
        public static double GetRun(double x1, double x2)
        {
            return x2 - x1;
        }
        /// <summary>
        /// Determine the distance between two X values on a graph
        /// </summary>
        /// <param name="p1">Point 1</param>
        /// <param name="p2">Point 2</param>
        /// <returns></returns>
        public static double GetRun(Point p1, Point p2)
        {
            return GetRun(p1.X, p2.X);
        }
        /// <summary>
        /// Determines the distance between two coordinates on a graph
        /// </summary>
        /// <param name="x1">The X coordinate of the first point</param>
        /// <param name="y1">The Y coordinate of the first point</param>
        /// <param name="x2">The X coordinate of the second point</param>
        /// <param name="y2">The Y coordinate of the second point</param>
        /// <returns></returns>
        public static double GetDistance(double x1, double y1, double x2, double y2)
        {
            double x3, y3;
            x3 = x2 - x1;
            y3 = y2 - y1;
            return GetHypotenuse(x3, y3);
        }
        /// <summary>
        /// Determnes the distance between two points on a graph
        /// </summary>
        /// <param name="p1">Point one</param>
        /// <param name="p2">Point two</param>
        /// <returns>The distance</returns>
        public static double GetDistance(Point p1, Point p2)
        {
            return GetDistance(p1.X, p1.Y, p2.X, p2.Y);
        }
        /// <summary>
        /// Gets the slope of a line
        /// </summary>
        /// <param name="x1">The X coordinate of the first point</param>
        /// <param name="y1">The Y coordinate of the first point</param>
        /// <param name="x2">The X coordinate of the second point</param>
        /// <param name="y2">The Y coordinate of the second point</param>
        /// <returns></returns>
        public static double GetSlope(double x1, double y1, double x2, double y2)
        {
            return GetRise(y1, y2) / GetRun(x1, x2);
        }
        /// <summary>
        /// Gets the slope of a line
        /// </summary>
        /// <param name="p1">Point one</param>
        /// <param name="p2">point two</param>
        /// <returns>The slope</returns>
        public static double GetSlope(Point p1, Point p2)
        {
            return GetSlope(p1.X, p1.Y, p2.X, p2.Y);
        }
        /// <summary>
        /// Determines the Y intercept
        /// </summary>
        /// <param name="x1">The X coordinate</param>
        /// <param name="y1">The Y coordinate</param>
        /// <param name="slope">The slope</param>
        /// <returns>The Y intercept</returns>
        public static double GetYIntercept(double x1, double y1, double slope)
        {
            return y1 - (slope * x1);
        }
        /// <summary>
        /// Determines if a triangle is right or not
        /// </summary>
        /// <param name="side1">The length of a side</param>
        /// <param name="side2">The length of a different side</param>
        /// <param name="side3">The length of the last side</param>
        /// <returns>If the triangle is right or not</returns>
        public static bool IsRight(double side1, double side2, double side3)
        {
            bool isRight = false;
            if (Math.Pow(side1, 2) == Math.Pow(side2, 2) + Math.Pow(side3, 2) || Math.Pow(side2, 2) == Math.Pow(side1, 2) + Math.Pow(side3, 2) || Math.Pow(side3, 2) == Math.Pow(side2, 2) + Math.Pow(side1, 2))
            {
                isRight = true;
            }
            return isRight;
        }
        /// <summary>
        /// Generates a random list of numbers
        /// </summary>
        /// <param name="min">The minimum requested value</param>
        /// <param name="max">The maximum requested value</param>
        /// <param name="size">The amount of numbers requested</param>
        /// <returns>A list of randomly generated numbers</returns>
        public static List <int> GetRandomList(int min, int max, int size)
        {
            List<int> numbers = new List<int>();
            Random generator = new Random();
            for (int i = 0; i < size; i++)
            {
                numbers.Add(generator.Next(min, max + 1));
            }
            return numbers;
        }
        /// <summary>
        /// Generates a random array of numbers
        /// </summary>
        /// <param name="min">The minimum requested value</param>
        /// <param name="max">The maximum requested value</param>
        /// <param name="size">The amount of numbers requested</param>
        /// <returns>An array of randomly generated numbers</returns>
        public static int[] GetRandomArray(int min, int max, int size)
        {
            int[] numbers = new int[size];
            Random generator = new Random();
            for (int i = 0; i < size; i++)
            {
                numbers[i] = generator.Next(min, max + 1);
            }
            return numbers;
        }
        /// <summary>
        /// Reverses the text in a string variable
        /// </summary>
        /// <param name="line">The string variable</param>
        /// <returns>The same string but in reverse</returns>
        public static string Reverse(string line)
        {
            string word = "";
            for (int i = line.Count() - 1; i >= 0; i--)
            {
                word += line[i];
            }
            return word;
        }
        /// <summary>
        /// Calculates the mean of the numbers in a list
        /// </summary>
        /// <param name="list">The list of numbers</param>
        /// <returns>The mean</returns>
        public static double Average(List<int> list)
        {
            double average = 0;
            for (int i = 0; i < list.Count(); i++)
            {
                average += list[i];
            }
            average = average / list.Count();
            return Math.Round(average, 2);
        }
        /// <summary>
        /// Checks how many roots a parabola has
        /// </summary>
        /// <param name="a">Coefficient of x^2</param>
        /// <param name="b">Coefficient of x</param>
        /// <param name="c">Coeficcient of 1</param>
        /// <returns>How many roots there are</returns>
        public static int RootChecker(double a, double b, double c)
        {
            double roots;
            roots = Math.Pow(b, 2) - (4 * a * b);
            if (roots > 0)
                return 2;
            else if (roots == 0)
                return 1;
            else
                return 0;
        }
        /// <summary>
        /// Calculates the circumference of a circle
        /// </summary>
        /// <param name="diameter">The diameter</param>
        /// <returns>The circumference</returns>
        private static double Circumference(double diameter)
        {
            double circumference;
            circumference = Math.PI * diameter;
            return circumference;
        }
        /// <summary>
        /// Calculates the area of a rectangle
        /// </summary>
        /// <param name="side1">The length</param>
        /// <param name="side2">The width</param>
        /// <returns>The area</returns>
        private static double CalculateAreaRectangle(double side1, double side2)
        {
            return side1 * side2;
        }
    }
}
