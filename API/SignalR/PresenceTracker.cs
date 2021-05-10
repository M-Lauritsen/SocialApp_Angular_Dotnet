using System.Collections.Generic;

namespace API.SignalR
{
    public class PresenceTracker
    {
        private static readonly Dictionary<string, List<string>> OnlineUser = 
            new Dictionary<string, List<string>>();
    }
}