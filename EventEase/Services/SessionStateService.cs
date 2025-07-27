using EventEase.Models;

public class SessionStateService
{
    public RegistrationData? CurrentUser { get; private set; }

    public void SetCurrentUser(RegistrationData user)
    {
        CurrentUser = user;
    }
}