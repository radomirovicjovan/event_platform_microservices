namespace EventPlatformAPI.Web.Domains;

public class LecturerEvent
{
    public int Id { get; set; }
    public int LecturerId { get; set; }
    public int EventId { get; set; }
    public DateTime Time { get; set; }

    public Lecturer? Lecturer { get; set; }
    public Event? Event { get; set; }
}
