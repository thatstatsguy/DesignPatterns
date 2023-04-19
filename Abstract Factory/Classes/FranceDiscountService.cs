using Abstract_Factory.Interfaces;

namespace Abstract_Factory.Classes;

/// <summary>
/// Concrete Product
/// </summary>
public class FranceDiscountService : IDiscountService
{
    public int DiscountPercentage => 10;
}