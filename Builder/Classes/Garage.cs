namespace Builder.Classes;

/// <summary>
/// Director
/// </summary>
public class Garage
{
    private CarBuilder? _carBuilder;

    public Garage()
    {
        
    }
    public void Construct(CarBuilder carBuilder)
    {
        _carBuilder = carBuilder;
        _carBuilder.BuildEngine();
        _carBuilder.BuildFrame();
    }

    public void Show()
    {
        Console.WriteLine(_carBuilder?.Car.ToString());
    }
}