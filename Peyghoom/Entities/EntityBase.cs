using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Peyghoom.Entities
{
    public class EntityBase
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
    }
}
