using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNETMVCSignalR.Hubs
{
    [HubName("peoplesHub")]
    public class PeoplesHub : Hub
    {
        public static void BroadcastData()
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<PeoplesHub>();
            context.Clients.All.refreshPeopleData();
        }
    }
}