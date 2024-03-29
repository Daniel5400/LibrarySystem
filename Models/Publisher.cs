using System.Text.Json.Serialization;

namespace WebDev_CW.Models
{


public class Publisher
{
    public int PublisherID { get; set; }
    public required string Name { get; set; }
    [JsonIgnore]
    public List<Book>? Books { get; set; }
}
}