namespace CodTrackerCore.Models
{
    public class Match
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public User User { get; set; }

        public DateTime Date { get; set; }

        public int Kills { get; set; }

        public int Deaths { get; set; }

        public int Damage { get; set; }
        
    }
}
