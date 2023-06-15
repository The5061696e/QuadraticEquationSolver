using Xunit;
using QuadraticEquationSolver;

namespace QuadraticEquationSolver.Tests
{
    public class QuadraticEquationSolverTests
    {
        [Fact]
        public void Solve_ShouldReturnNoRoots()
        {
            double a = 1;
            double b = 2;
            double c = 3;

            var result = QuadraticEquationSolver.Solve(a, b, c);

            Assert.Null(result.Item1);
            Assert.Null(result.Item2);
        }

        [Fact]
        public void Solve_ShouldReturnOneRoot()
        {
            double a = 1;
            double b = -4;
            double c = 4;

            var result = QuadraticEquationSolver.Solve(a, b, c);

            Assert.Equal(2, result.Item1);
            Assert.Null(result.Item2);
        }

        [Fact]
        public void Solve_ShouldReturnTwoRoots()
        {
            double a = 1;
            double b = -5;
            double c = 6;

            var result = QuadraticEquationSolver.Solve(a, b, c);

            Assert.Equal(3, result.Item1);
            Assert.Equal(2, result.Item2);
        }
    }
}