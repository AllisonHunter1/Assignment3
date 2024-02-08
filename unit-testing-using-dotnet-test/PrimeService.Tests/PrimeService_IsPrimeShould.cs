using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        #region Sample_TestCode
        [Theory] //represents a suite of tests, execute the same code with dif inputs 
        [InlineData(-1)]  //said inputs.
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);  //returns test result

            Assert.False(result, $"{value} should not be prime");
        }
        #endregion

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)] //if changed to 4, 1 failed
        public void IsPrime_PrimesLessThan10_ReturnTrue(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.True(result, $"{value} should be prime");
        }

        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(9)] //if changed to 11 returns 1 failed
        public void IsPrime_NonPrimesLessThan10_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }

    }
}





