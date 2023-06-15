using System;
using Xunit;

namespace QuadraticEquationSolver.Tests
{
    public class QuadraticEquationSolverTests
    {
        [Fact]
        public void TestNoRealRoots()
        {
            // Arrange
            double a = 1;
            double b = 0;
            double c = 1;

            // Act
            double[] solutions = QuadraticEquationSolver.Solve(a, b, c);

            // Assert
            Assert.Empty(solutions);
        }

        [Fact]
        public void TestOneRealRoot()
        {
            // Arrange
            double a = 1;
            double b = -2;
            double c = 1;
            double expectedRoot = 1;

            // Act
            double[] solutions = QuadraticEquationSolver.Solve(a, b, c);

            // Assert
            Assert.Single(solutions);
            Assert.Equal(expectedRoot, solutions[0]);
        }

        [Fact]
        public void TestTwoRealRoots()
        {
            // Arrange
            double a = 1;
            double b = -3;
            double c = 2;
            double expectedRoot1 = 1;
            double expectedRoot2 = 2;

            // Act
            double[] solutions = QuadraticEquationSolver.Solve(a, b, c);

            // Assert
            Assert.Equal(2, solutions.Length);
            Assert.Equal(expectedRoot1, solutions[0]);
            Assert.Equal(expectedRoot2, solutions[1]);
        }
    }
}
