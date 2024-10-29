using Demo.Core.Entities;
using System.Text.Json.Serialization;

namespace Demo.Services.Product.Product
{
    public class ProductResponse
    {
        public List<ProductR> products { get; set; }
    }

    public class ProductR
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }

        [JsonPropertyName("dimensions")]
        public Dimension Dimensions { get; set; }

    }

    public class Dimension
    {
        [JsonPropertyName("depth")]
        public double Depth { get; set; }

        [JsonPropertyName("height")]
        public double Height { get; set; }

        [JsonPropertyName("width")]
        public double Width { get; set; }
    }

}
