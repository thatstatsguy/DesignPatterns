namespace Abstract_Factory.Interfaces;

/// <summary>
/// Abstract Factory
/// </summary>
public interface IShoppingCartPurchaseFactory
{
    IDiscountService CreateDiscountService();
    IShippingCostsService CreateShippingCostsService();
}