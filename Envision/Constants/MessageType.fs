namespace Envision.Constants

module MessageType =
    type Navigation = 
    | Main 
    | Versions

    type Actions = 
    | NavigationAction of Navigation
    | Increment