using Abstract_Factory.Interfaces;

namespace Abstract_Factory.Classes;

/// <summary>
/// Client
/// </summary>
public class ShoppingCart
{
    private readonly IDiscountService _discountService;
    private readonly IShippingCostsService _shippingCostsService;

    private int _orderTotal;
    //notice how the services are always generated from the same factory
    public ShoppingCart(IShoppingCartPurchaseFactory factory)
    {
        _discountService = factory.CreateDiscountService();
        _shippingCostsService = factory.CreateShippingCostsService();

        _orderTotal = 100;
    }

    public void CalculateCosts()
    {
        Console.WriteLine($"Cost: {_orderTotal}, Discount: {_discountService.DiscountPercentage}, Shipping Costs: {_shippingCostsService.ShippingCosts}");
    }
    

}