﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace HelloSignalR
{
    public class Chat : Hub
    {
        public Task Send(string message)
        {
            return Clients.All.InvokeAsync("Send", message);
        }
    }
}
