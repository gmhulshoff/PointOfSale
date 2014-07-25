using PointOfSale;
using NUnit.Framework;
using System.Collections.Generic;

public class PointOfSaleTest
{
    PointOfSaleTerminal terminal;

    [SetUp]
    public void When()
    {
        terminal = new PointOfSaleTerminal();
        terminal.SetPricing(new Dictionary<char, Pricing>{
            {'A', new Pricing(1.25, 3, 3.00)},
            {'B', new Pricing(4.25)},
            {'C', new Pricing(1.00, 6, 5.00)},
            {'D', new Pricing(0.75)},
        });
    }

    [TestCase("A", Result = 1.25)]
    [TestCase("B", Result = 4.25)]
    [TestCase("C", Result = 1.00)]
    [TestCase("D", Result = 0.75)]
    [TestCase("AAA", Result = 3.00)]
    [TestCase("ABCDABA", Result = 13.25)]
    [TestCase("CCCCCCC", Result = 6)]
    [TestCase("ABCD", Result = 7.25)]
    public double Then_total_is_calculated_correct(string product)
    {
        terminal.Scan(product);
        return terminal.CalculateTotal();
    }
}