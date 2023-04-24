namespace Builder.Classes;

public class BMWBuilder : CarBuilder
{
    public BMWBuilder() : base("BMW")
    {
    }

    public override void BuildEngine()
    {
        this.Car.AddPart("v8 engine");
    }

    public override void BuildFrame()
    {
        this.Car.AddPart("5 door wannabe racing car");
    }
}