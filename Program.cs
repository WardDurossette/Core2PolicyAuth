﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Core2PolicyAuth
{
    public class Program
    {

        private static string settingPath = Path.GetFullPath(Path.Combine(@"../../secrets.json")); // get absolute path

        public static void Main(string[] args)
        {
 
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .ConfigureAppConfiguration(((builderContext, config) => {
                  config.AddJsonFile(settingPath);
                }))
                .Build();
    }
}
