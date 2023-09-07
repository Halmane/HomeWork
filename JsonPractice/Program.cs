using System.Reflection;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

JsonSerializerOptions options = new JsonSerializerOptions()
{
    Converters = { new ChannelJsonConverter() }
};
var json = JsonSerializer.Serialize(new Channel(), options);
Console.WriteLine(json);

public class ChannelConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert)
    {
        if (!typeToConvert.IsGenericType)
        {
            return false;
        }

        if (typeToConvert.GetGenericTypeDefinition() != typeof(Channel))
        {
            return false;
        }

        return true;
    }

    public override JsonConverter CreateConverter(Type type, JsonSerializerOptions options)
    {
        Type genericType = type.GetGenericArguments()[0];

        JsonConverter converter = (JsonConverter)
            Activator.CreateInstance(
                typeof(ChannelJsonConverter).MakeGenericType(new Type[] { genericType }),
                BindingFlags.Instance | BindingFlags.Public,
                binder: null,
                args: new object[] { genericType },
                culture: null
            )!;

        return converter;
    }
}

public class ChannelJsonConverter : JsonConverter<Channel>
{
    public ChannelJsonConverter() { }

    public override Channel? Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, Channel value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteString("Name", value.Name);
        writer.WriteString("Info", value.Info);
        writer.WriteNumber("Channel", value.ChannelNumber);
        writer.WriteEndObject();
    }
}

public class Channel
{
    public string Name { get; set; } 
    public string Info { get; set; }
    public int ChannelNumber { get; set; }
}
