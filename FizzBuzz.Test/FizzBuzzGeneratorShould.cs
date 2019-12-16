using System;
using Xunit;

namespace FizzBuzz.Test
{
    public class FizzBuzzGeneratorShould
    {
        private FizzBuzzGenerator _fizzBuzzGenerator;

        public FizzBuzzGeneratorShould()
        {
            _fizzBuzzGenerator = new FizzBuzzGenerator();
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(18)]
        public void PrintFizzWhenDivisibleByThree(int input)
        {
            //  Act            
            var stringResult = _fizzBuzzGenerator.ModifyOutput(input);

            //  Assert
            Assert.Equal("Fizz", stringResult);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(25)]
        [InlineData(55)]
        public void PrintBuzzWhenDivisibleByFive(int input)
        {
            //  Act            
            var stringResult = _fizzBuzzGenerator.ModifyOutput(input);

            //  Assert
            Assert.Equal("Buzz", stringResult);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(60)]
        [InlineData(75)]
        public void PrintFizzBuzzWhenDivisibleByThreeAndFive(int input)
        {
            //  Act            
            var stringResult = _fizzBuzzGenerator.ModifyOutput(input);

            //  Assert
            Assert.Equal("FizzBuzz", stringResult);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(11)]
        [InlineData(29)]
        public void DoesNotPrintStringWhenUndivisibleByThreeOrFive(int input)
        {            
            //  Act            
            var stringResult = _fizzBuzzGenerator.ModifyOutput(input);

            //  Assert
            Assert.Equal("", stringResult);
        }

        
    }
}
