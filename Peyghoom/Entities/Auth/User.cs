using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace Peyghoom.Entities.Auth
{
    public class User : EntityBase
    {
        [BsonElement("email")]
        [JsonPropertyName("email")]
        public string? Email { get; set; }
        [BsonElement("password")]
        [JsonPropertyName("password")]
        public string? Password { get; set; }
        [BsonElement("age")]
        [JsonPropertyName("age")]
        public int Age { get; set; }
    }
}
