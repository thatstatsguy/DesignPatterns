using Abstract_Factory.Interfaces;

namespace Abstract_Factory.Classes;

/// <summary>
/// Concrete Product
/// </summary>
public class FranceShippingCostsService : IShippingCostsService
{
    public decimal ShippingCosts => 60;
}