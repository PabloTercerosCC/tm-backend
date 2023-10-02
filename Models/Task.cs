using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace tm_backend.Models;

public class Task
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("Name")]
    public string Text { get; set; } = null!;

    public string Day { get; set; } = null!;

    public bool Reminder { get; set; }
}