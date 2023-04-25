using Newtonsoft.Json;

namespace Prototype;

public class Employee : Person
{
    public Employee(string name, Manager manager)
    {
        Name = name;
        Manager = manager;
    }

    public override string Name { get; set; }
    public Manager Manager { get; set; }
    
    /// <summary>
    /// note - could use ICloneable, but then there's issues around how to indicate whether or not this is a deep copy
    /// </summary>
    /// <param name="deepClone"></param>
    /// <returns></returns>
    public override Person Clone(bool deepClone = false)
    {
        if (deepClone)
        {
            //do not use binary formatter here for deep copy - microsoft mentions it has security issues
            // var formatter = new BinaryFormatter();
            // using (var stream = new MemoryStream())
            // {
            //     formatter.Serialize(stream, this);
            //     stream.Seek(0, SeekOrigin.Begin);
            //     return (Person)formatter.Deserialize(stream);
            // }
        
            var objectAsJson = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<Employee>(objectAsJson);
        }
        //instead of newing up, use member wise clone
        //creates a shallow copy
        return (Person)MemberwiseClone();
    }
}