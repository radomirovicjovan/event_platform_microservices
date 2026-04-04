namespace EventPlatformAPI.Web.Domains;

public class Event
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Agenda { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public decimal Duration { get; set; } 
    public decimal Price { get; set; }
    public int LocationId { get; set; }
    public int EventTypeId { get; set; }

    public Location? Location { get; set; }
    public EventType? EventType { get; set; }
    public ICollection<LecturerEvent> LecturerEvents { get; set; } = new List<LecturerEvent>();
}
