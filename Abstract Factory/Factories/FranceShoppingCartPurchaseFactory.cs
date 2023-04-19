using Abstract_Factory.Classes;
using Abstract_Factory.Interfaces;

namespace Abstract_Factory.Factories;

/// <summary>
/// Concrete Factory
/// </summary>
public class FranceShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
{
    public IDiscountService CreateDiscountService()
    {
        return new FranceDiscountService();
    }

    public IShippingCostsService CreateShippingCostsService()
    {
        return new FranceShippingCostsService();
    }
}