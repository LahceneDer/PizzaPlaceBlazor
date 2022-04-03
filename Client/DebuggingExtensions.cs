using System.Text.Json;

namespace PizzaPlace.Client
{
    public class DebuggingExtensions
    {
        private static JsonSerializerOptions options = new JsonSerializerOptions {WriteIndented = true};

        public static string ToJson(object obj) => JsonSerializer.Serialize(obj, options);
    }
}