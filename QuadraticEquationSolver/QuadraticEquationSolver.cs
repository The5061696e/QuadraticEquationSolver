using System;

namespace QuadraticEquationSolver
{
    public class QuadraticEquationSolver
    {
        public static (double?, double?) Solve(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                return (null, null);
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                return (x, null);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return (x1, x2);
            }
        }
    }
}