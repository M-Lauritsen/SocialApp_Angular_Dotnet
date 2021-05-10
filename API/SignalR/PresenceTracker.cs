using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.SignalR
{
    public class PresenceTracker
    {
        private static readonly Dictionary<string, List<string>> OnlineUser = 
            new Dictionary<string, List<string>>();

        public Task UserConnected(string username, string connectionId)
        {
            lock (OnlineUser)
            {
                if(OnlineUser.ContainsKey(username))
                {
                    OnlineUser[username].Add(connectionId);
                }
            }
        }
    }
}