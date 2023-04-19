using Abstract_Factory.Interfaces;

namespace Abstract_Factory.Classes;

/// <summary>
/// Concrete Product
/// </summary>
public class BelgiumShippingCostsService : IShippingCostsService
{
    public decimal ShippingCosts => 50;
}