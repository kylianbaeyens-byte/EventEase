using MyBlazorApp.Models;

namespace MyBlazorApp.Services;

// Holds app-wide state for the current user session: who is registered
// and which events they are attending. Registered as a singleton so the
// session persists across page navigation. Components subscribe to
// OnChange to re-render when the session updates.
public class UserSessionService
{
    private readonly HashSet<int> _attendingEventIds = new();

    public string? UserName { get; private set; }
    public string? UserEmail { get; private set; }

    public bool IsSignedIn => !string.IsNullOrWhiteSpace(UserEmail);

    public IReadOnlyCollection<int> AttendingEventIds => _attendingEventIds;

    public event Action? OnChange;

    // Records the user for the session and marks them attending the event.
    public void Register(RegistrationModel registration, int eventId)
    {
        UserName = registration.Name;
        UserEmail = registration.Email;
        _attendingEventIds.Add(eventId);
        NotifyChanged();
    }

    public bool IsAttending(int eventId) => _attendingEventIds.Contains(eventId);

    public void CancelAttendance(int eventId)
    {
        if (_attendingEventIds.Remove(eventId))
        {
            NotifyChanged();
        }
    }

    public void SignOut()
    {
        UserName = null;
        UserEmail = null;
        _attendingEventIds.Clear();
        NotifyChanged();
    }

    private void NotifyChanged() => OnChange?.Invoke();
}
