using System.ComponentModel.DataAnnotations;

namespace MyBlazorApp.Models;

// Simple data model that backs the Event Card and the details/registration pages.
// Data annotations drive validation so invalid input is caught before it is processed.
public class EventDetail
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Event name is required.")]
    [StringLength(100, ErrorMessage = "Event name must be 100 characters or fewer.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Event date is required.")]
    [DataType(DataType.Date)]
    public DateTime Date { get; set; }

    [Required(ErrorMessage = "Location is required.")]
    [StringLength(150, ErrorMessage = "Location must be 150 characters or fewer.")]
    public string Location { get; set; } = string.Empty;
}
