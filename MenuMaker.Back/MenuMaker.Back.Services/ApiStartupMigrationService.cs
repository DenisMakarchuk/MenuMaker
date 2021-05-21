using MenuMaker.Back.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MenuMaker.Back.Services
{
    public static class ApiStartupMigrationService
    {
        public static void ApplyMigration(IServiceProvider services)
        {
            var context = (DbContext) services.GetRequiredService<DataContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
        }
    }
}
