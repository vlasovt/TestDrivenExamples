using System;
using Xunit;

namespace TestDrivenFibonacci.Tests
{
    public class FibonacciUnitTests
    {
        [Fact]
        public void Fib_Given0_Return0()
        {
            RunFibonacciTest(0, 0);
        }

        [Fact]
        public void Fib_Given1_Return1()
        {
            RunFibonacciTest(1, 1);
        }

        [Fact]
        public void Fib_Given2_Return1()
        {
            RunFibonacciTest(2, 1);
        }

        [Fact]
        public void Fib_Given3_Return2()
        {
            RunFibonacciTest(3, 2);
        }

        [Fact]
        public void Fib_Given4_Return3()
        {
            RunFibonacciTest(4, 3);
        }

        [Fact]
        public void Fib_Given11_Return89()
        {
            RunFibonacciTest(11, 89);
        }

        private void RunFibonacciTest(int input, int output) {
            
            //Arrange
            var n = input;

            //Act
            var result = Fibonacci.Fib(n);

            //Assert
            Assert.Equal(output, result);
        }
    }
}
