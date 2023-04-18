// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using Factory_Method_Pattern;

Console.WriteLine("Hello, World!");
var factories  = new List<DiscountFactory>
{
    new CodeDiscountFactory(Guid.NewGuid()),
    new CountryDiscountFactory("ZA")
};

foreach (var factory in factories)
{
    var discountingService = factory.CreateDiscountService();
    Console.WriteLine($"Discount of {discountingService}: {discountingService.DiscountPercentage}");
}