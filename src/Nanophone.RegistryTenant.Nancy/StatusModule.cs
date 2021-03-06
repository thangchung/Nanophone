﻿using System.Threading.Tasks;
using Nancy;
using Nanophone.RegistryTenant.Nancy.Logging;

namespace Nanophone.RegistryTenant.Nancy
{
    public class StatusModule : NancyModule
    {
        private static readonly ILog s_log = LogProvider.For<StatusModule>();

        public StatusModule()
        {
            Get("/status", parameters =>
            {
                s_log.Info("Status: OK");
                return Task.FromResult("OK");
            });
        }
    }
}
