﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LinksTracker.Startup))]
namespace LinksTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
