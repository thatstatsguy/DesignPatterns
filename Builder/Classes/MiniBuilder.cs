namespace Builder.Classes;


/// <summary>
/// Concrete builder
/// </summary>
public class MiniBuilder : CarBuilder
{
    public MiniBuilder() : base("Mini")
    {
    }

    public override void BuildEngine()
    {
        this.Car.AddPart("not a v8");
    }

    public override void BuildFrame()
    {
        this.Car.AddPart("3 door frame");
    }
}