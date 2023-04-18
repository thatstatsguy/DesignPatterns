namespace Factory_Method_Pattern;


// alternative to an interface - the thing that needs to be produced
// also known in the pattern structure as the "Product"
public abstract class DiscountService
{
    public abstract int DiscountPercentage { get; }
    public override string ToString()
    {
        return GetType().Name;
    }
}

//know as the concrete product in pattern structure
public class CountryDiscountService : DiscountService
{
    private readonly string _countryIdentifier;

    public CountryDiscountService(string countryIdentifier)
    {
        _countryIdentifier = countryIdentifier;
    }

    public override int DiscountPercentage
    {
        get
        {
            switch (_countryIdentifier)
            {
                case "ZA" :
                    return 20;
                default: return 10;
            }
        }
    }
}

//know as the concrete product in pattern structure
public class CodeDiscountService : DiscountService
{
    private readonly Guid _code;

    public CodeDiscountService(Guid code)
    {
        _code = code;
    }

    public override int DiscountPercentage => 15;
}


// used to specify a method which is used to create a "product"
// known as a "creator" in pattern structure
public abstract class DiscountFactory
{
    public abstract DiscountService CreateDiscountService();
}

// implements methods from the creator by overriding the factory method
// known as a "concrete creator"
public class CodeDiscountFactory : DiscountFactory
{
    private readonly Guid _code;

    public CodeDiscountFactory(Guid code)
    {
        _code = code;
    }

    public override DiscountService CreateDiscountService()
    {
        return new CodeDiscountService(_code);
    }
}

/// <summary>
/// Concrete creator
/// </summary>
public class CountryDiscountFactory : DiscountFactory
{
    private readonly string _countryIdentifier;

    public CountryDiscountFactory(string countryIdentifier)
    {
        _countryIdentifier = countryIdentifier;
    }

    public override DiscountService CreateDiscountService()
    {
        return new CountryDiscountService(_countryIdentifier);
    }
}
