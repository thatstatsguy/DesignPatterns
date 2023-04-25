using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;

namespace Prototype;

/// <summary>
/// Concrete prototype
/// </summary>
public class Manager : Person
{
    public Manager(string name)
    {
        Name = name;
    }

    public override string Name { get; set; }
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
            return JsonConvert.DeserializeObject<Manager>(objectAsJson);
        }
        //instead of newing up, use member wise clone
        //creates a shallow copy
        return (Person)MemberwiseClone();
    }
}