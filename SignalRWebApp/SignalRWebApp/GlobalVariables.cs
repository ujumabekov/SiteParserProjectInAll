using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRWebApp
{
    public static class GlobalVariables
    {
        public static HubEndpointConventionBuilder hubEndpoint { get; set; } 
    }
}
