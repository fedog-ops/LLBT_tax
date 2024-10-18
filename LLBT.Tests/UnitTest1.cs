using LLBT.Classes;
using LLBT.Interface;
using LLBT.Service;
using NUnit.Framework.Internal;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace LLBT.Tests

{
    public class TaxTests
    { 

        [Test]
        public void TestZeroTaxBand()
        {
            // Arrange
            decimal salary = 10000;
            decimal expected = 0;

            // Act

            TaxFactory taxFactory = new TaxFactory();
            ConsoleNotifier consoleNotifier = new ConsoleNotifier();
            var taxService = new TaxService(taxFactory, consoleNotifier);
            decimal tax = taxService.CalculateTax(salary);
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
            TaxFactory taxFactory = new TaxFactory();
            ConsoleNotifier consoleNotifier = new ConsoleNotifier();
            var taxService = new TaxService(taxFactory, consoleNotifier);
            decimal tax = taxService.CalculateTax(salary);

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
            TaxFactory taxFactory = new TaxFactory();
            ConsoleNotifier consoleNotifier = new ConsoleNotifier();
            var taxService = new TaxService(taxFactory, consoleNotifier);
            decimal tax = taxService.CalculateTax(salary);

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
            TaxFactory taxFactory = new TaxFactory();
            ConsoleNotifier consoleNotifier = new ConsoleNotifier();
            var taxService = new TaxService(taxFactory, consoleNotifier);
            decimal tax = taxService.CalculateTax(salary);

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
            TaxFactory taxFactory = new TaxFactory();
            ConsoleNotifier consoleNotifier = new ConsoleNotifier();
            var taxService = new TaxService(taxFactory, consoleNotifier);
            decimal tax = taxService.CalculateTax(salary);

            // Assert
            Assert.That(tax, Is.EqualTo(expected));
        }

    }
}
