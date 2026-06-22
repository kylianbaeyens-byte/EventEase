# EventEase

A Blazor WebAssembly app for browsing and registering for corporate and social events, built across the three EventEase course activities.

## Features

- **Event Card component** with two-way data binding ([Components/EventCard.razor](Components/EventCard.razor))
- **Routing** between the event list, details, and registration pages, with graceful handling of invalid routes
- **Validated registration form** (name + email) using `EditForm` and data annotations
- **User session state management** that tracks the signed-in user across pages ([Services/UserSessionService.cs](Services/UserSessionService.cs))
- **Attendance tracker** to view and cancel event registrations ([Pages/Attendance.razor](Pages/Attendance.razor))
- **Performance**: the event list uses `<Virtualize>` to stay fast with large datasets

## Run locally

```bash
dotnet run
```

Then open the URL shown in the console (typically `https://localhost:5001`).

## Project structure

| Path | Purpose |
|------|---------|
| `Components/EventCard.razor` | Reusable, optionally-editable event card |
| `Models/` | `EventDetail` and `RegistrationModel` data models |
| `Services/EventService.cs` | In-memory event data |
| `Services/UserSessionService.cs` | Session + attendance state |
| `Pages/` | Home, Events, EventDetails, Registration, Attendance |
