using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EMS.DAL.Models;

public class Position
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }
}
