using System;
using System.IO;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using MigrationEFWpfCore31.v6.DAL.Entities;

namespace MigrationEFWpfCore31.v6
{
    // Тестовое изменение
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {   
        public static IHostBuilder CreateHostBuilder(string[] args) => Microsoft.Extensions.Hosting.Host
                .CreateDefaultBuilder(args)
                .ConfigureServices(
                    (hostContext, services) => services
                       .AddDbContext<ContextDBBookinist>(opt =>
                       {
                           string path = Directory.GetCurrentDirectory();
                           opt.UseSqlServer(hostContext.Configuration.GetConnectionString("Database")
                               .Replace("[DataDirectory]", path));
                       } 
                    )
        );
    }
}
