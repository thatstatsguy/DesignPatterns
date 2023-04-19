using Abstract_Factory.Classes;
using Abstract_Factory.Interfaces;

namespace Abstract_Factory.Factories;


/// <summary>
/// Concrete Factory
/// </summary>
public class BelgiumShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
{
    public IDiscountService CreateDiscountService()
    {
        return new BelgiumDiscountService();
    }

    public IShippingCostsService CreateShippingCostsService()
    {
        return new BelgiumShippingCostsService();
    }
}