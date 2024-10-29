using System.Text.Json.Serialization;

namespace Demo.Core.Entities
{
    public class ProductE
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

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
