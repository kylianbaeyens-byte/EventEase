using MyBlazorApp.Models;

namespace MyBlazorApp.Services;

// In-memory mock data source. Registered as a singleton so the list,
// details, and registration pages all share the same events.
public class EventService
{
    private readonly List<EventDetail> _events = new()
    {
        new EventDetail { Id = 1, Name = "Annual Tech Conference", Date = new DateTime(2026, 9, 18), Location = "Brussels Expo" },
        new EventDetail { Id = 2, Name = "Charity Gala Dinner", Date = new DateTime(2026, 10, 5), Location = "Antwerp City Hall" },
        new EventDetail { Id = 3, Name = "Product Launch Party", Date = new DateTime(2026, 11, 12), Location = "Ghent Innovation Hub" },
    };

    public IReadOnlyList<EventDetail> GetEvents() => _events;

    public EventDetail? GetEvent(int id) => _events.FirstOrDefault(e => e.Id == id);
}
