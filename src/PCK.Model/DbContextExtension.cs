﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Newtonsoft.Json;

namespace PCK.Model
{
    public static class DbContextExtension
    {

        public static bool AllMigrationsApplied(this DbContext context)
        {
            var applied = context.GetService<IHistoryRepository>()
                .GetAppliedMigrations()
                .Select(m => m.MigrationId);

            var total = context.GetService<IMigrationsAssembly>()
                .Migrations
                .Select(m => m.Key);

            return !total.Except(applied).Any();
        }
        public static void EnsureSeeded(this SalesContext context)
        {

            //if (!context.Type.Any())
            //{
            //    var types = JsonConvert.DeserializeObject<List<ThreatType>>(File.ReadAllText("seed" + Path.DirectorySeparatorChar + "types.json"));
            //    context.AddRange(types);
            //    context.SaveChanges();
            //}

            ////Ensure we have some status
            //if (!context.Status.Any())
            //{
            //    var stati = JsonConvert.DeserializeObject<List<Status>>(File.ReadAllText(@"seed" + Path.DirectorySeparatorChar + "status.json"));
            //    context.AddRange(stati);
            //    context.SaveChanges();

            //}
            ////Ensure we create initial Threat List
            //if (!context.Threats.Any())
            //{
            //    List<Threat> threats = JsonConvert.DeserializeObject<List<Threat>>(File.ReadAllText(@"seed" + Path.DirectorySeparatorChar + "threats.json"));
            //    context.Threats.AddRange(threats);
            //    context.SaveChanges();
            //}
        }
    }
}