namespace CodTrackerCore.Models;

public class Match
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public string UserId { get; set; }

    public DateTime Date { get; set; }

    public int Kills { get; set; }

    public int Deaths { get; set; }

    public int Damage { get; set; }

}
