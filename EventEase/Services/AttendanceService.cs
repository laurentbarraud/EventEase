using EventEase.Models;


// This service handles tracking who registered for which events.
// It's meant to be injected as a scoped service (per user session).
public class AttendanceService
{
    // This dictionary stores attendance data.
    // - Key: the event name (string)
    // - Value: a list of RegistrationData objects (each representing one participant)
    private readonly Dictionary<string, List<RegistrationData>> _attendance = new();

    // Registers a participant for a given event.
    public void Register(string eventName, RegistrationData data)
    {
        // Check if the event already exists in the dictionary
        if (!_attendance.ContainsKey(eventName))
        {
            // If it doesn't exist, create a new entry with an empty list
            _attendance[eventName] = new List<RegistrationData>();
        }

        // Add the participant data to the list of attendees for the event
        _attendance[eventName].Add(data);
    }

    // Retrieves the list of all participants registered for a specific event.
    public IReadOnlyList<RegistrationData> GetAttendees(string eventName)
    {
        // Try to get the list of attendees for the event
        if (_attendance.TryGetValue(eventName, out var list))
        {
            // Return the list as a read-only collection (safe for viewing, not modifying)
            return list.AsReadOnly();
        }

        // If no one registered for the event, return an empty list
        return new List<RegistrationData>();
    }
}
