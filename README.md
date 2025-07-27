### Blazor web app to simulate event management

I have created, debugged, and enhanced components for this app using Microsoft Copilot.

I asked in this order to :
- generate a basic razor component for the Event Card, which include fields for event name, date, and location
- implement two-way data binding and create navigation links between the event list, details, and registration pages
- verify routing paths, ensuring best practices
- do validation to ensure only valid data is processed in the Event Card (buggy)
- update routing logic to gracefully handle invalid paths and optimize performance by improving how event data is rendered
- a separate registration form with data validation for user input (name and email)
- state management to track user sessions and an attendance tracker to monitor event participation
- remove unnecessary dependencies

A persistent bug is preventing me from registering to any event (the validation always believes the name and email fields are empty)
but after over 4 hours stuck on that bug, with over 20 "quick fixes" from Copilot that changed nothing, I just decided to push this online and move on.
Thanks for your understanding.


