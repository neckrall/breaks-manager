namespace BreaksManager.Models;

public class Slot
{
    public static readonly TimeSpan Size = TimeSpan.FromMinutes(10);

    public required TimeSpan Time { get; init; }
    public required Activity Activity { get; set; }
}
