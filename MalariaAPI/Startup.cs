﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(MalariaAPI.Startup))]

namespace MalariaAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
