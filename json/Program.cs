using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

var options = new JsonSerializerOptions
{
    TypeInfoResolver = new UpperCasePropertyContractResolver()
};

var result = JsonSerializer.Serialize(
    new { 
    curso = ".NET 7 esencial", 
    autor = "Rodrigo Díaz Concha" 
    }, options);
System.Console.WriteLine(result);
public class UpperCasePropertyContractResolver : DefaultJsonTypeInfoResolver
{
    public override JsonTypeInfo GetTypeInfo(Type type, JsonSerializerOptions options)
    {
        JsonTypeInfo typeInfo = base.GetTypeInfo(type, options);

        if (typeInfo.Kind == JsonTypeInfoKind.Object)
        {
            foreach (JsonPropertyInfo property in typeInfo.Properties)
            {
                property.Name = property.Name.ToUpperInvariant();
            }
        }

        return typeInfo;
    }
}