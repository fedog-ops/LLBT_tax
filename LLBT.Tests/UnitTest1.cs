using LLBT.BandsClasses;
using LLBT.BandsFactory;
using LLBT.Input;
using LLBT.Notifier;
using LLBT.Service;
using LLBT.Strategy;
using NUnit.Framework.Internal;

namespace LLBT.Tests

{
    public class TaxTests
    {
        private TaxService _taxService;
        [SetUp]
        
        public void SetUp()
        {
            ITaxFactory llbtTaxes = new LLBTTaxBands();
            TaxStrategy taxStrategy = new TaxStrategy();
            ConsoleNotifier consoleNotifier = new ConsoleNotifier();
            var taxService = new TaxService(llbtTaxes, taxStrategy, consoleNotifier);
            _taxService = new TaxService(llbtTaxes, taxStrategy, consoleNotifier);
        }
            
        [Test]
        public void TestZeroTaxBand()
        {
            // Arrange
            decimal salary = 10000;
            decimal expected = 0;

            // Act
         
           
            decimal tax = _taxService.CalculateTax(salary);

            // Assert
            Assert.That(tax, Is.EqualTo(expected));
        }
        [Test]
        public void TestTwoTaxBand()
        {
            // Arrange
            decimal salary = 200000;
            decimal expected = 1099.98m;

            // Act

            decimal tax = _taxService.CalculateTax(salary);
            // Assert
            Assert.That(tax, Is.EqualTo(expected));
        }
        [Test]
        public void TestFiveTaxBand()
        {
            // Arrange
            decimal salary = 275000;
            decimal expected = 3349.93m;

            // Act
            decimal tax = _taxService.CalculateTax(salary);

            // Assert
            Assert.That(tax, Is.EqualTo(expected));
        }
        [Test]
        public void TestTenTaxBand()
        {
            // Arrange
            decimal salary = 500000;
            decimal expected = 23349.83m;

            // Act
            decimal tax = _taxService.CalculateTax(salary);

            // Assert
            Assert.That(tax, Is.EqualTo(expected));
        }
        [Test]
        public void TestTwelveTaxBand()
        {
            // Arrange
            decimal salary = 1000000;
            decimal expected = 78349.71m;

            // Act
            decimal tax = _taxService.CalculateTax(salary);
            // Assert
            Assert.That(tax, Is.EqualTo(expected));
        }

        private class Mock<T>
        {
        }
    }
}
