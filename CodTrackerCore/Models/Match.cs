namespace CodTrackerCore.Models;

public class Match
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [Required]
    public string UserId { get; set; }

    [Required]
    public string GameModeId { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    public int Kills { get; set; }

    [Required]
    public int Deaths { get; set; }

    [Required]
    public int Damage { get; set; }

}
