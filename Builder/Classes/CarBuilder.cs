namespace Builder.Classes;

/// <summary>
/// Builder
/// </summary>
public abstract class CarBuilder
{
    protected CarBuilder(string carType)
    {
        Car = new Car(carType);
    }

    public Car Car { get; private set; }
    public abstract void BuildEngine();
    public abstract void BuildFrame();
}