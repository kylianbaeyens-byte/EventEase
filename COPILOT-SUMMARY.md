# How Microsoft Copilot Assisted in Development

A brief summary of how Microsoft Copilot supported each step of building the EventEase app across the three activities.

## Activity 1 — Foundation

- **Event Card component:** Copilot scaffolded the structure of `EventCard.razor` and suggested the fields for event name, date, and location.
- **Data model:** Copilot proposed the `EventDetail` model and its properties.
- **Two-way data binding:** Copilot generated and refined the `@bind` / `@bind-Value` syntax for displaying and editing event details.
- **Routing:** Copilot suggested the `@page` route templates and the `NavLink` navigation between the event list, details, and registration pages.

## Activity 2 — Debugging & Optimization

- **Input validation:** Copilot recommended data-annotation attributes (`[Required]`, `[StringLength]`) and wrapping inputs in an `EditForm` with `DataAnnotationsValidator` so invalid or empty data is rejected.
- **Routing errors:** Copilot suggested the `{Id:int}` route constraint plus a `NotFound` fallback page to gracefully handle invalid paths, and "event not found" messaging for missing ids.
- **Performance:** Copilot identified the event list as a bottleneck for large datasets and recommended `<Virtualize>` to render only items in view.

## Activity 3 — Comprehensive Project

- **Registration form:** Copilot helped design the `RegistrationModel` with `[Required]` and `[EmailAddress]` validation for name and email.
- **State management:** Copilot suggested the `UserSessionService` (a singleton with a change event) to track the signed-in user and their registrations across page navigation.
- **Attendance tracker:** Copilot helped build the `Attendance` page to list, cancel, and monitor event participation.
- **Production readiness:** Copilot flagged the template's demo Counter/Weather pages for removal, suggested a clean EventEase landing page, and helped add a `.gitignore` and README for deployment.
