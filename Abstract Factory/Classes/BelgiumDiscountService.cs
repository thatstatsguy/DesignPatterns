using Abstract_Factory.Interfaces;

namespace Abstract_Factory.Classes;

/// <summary>
/// Concrete product
/// </summary>
public class BelgiumDiscountService : IDiscountService
{
    public int DiscountPercentage => 20;
}