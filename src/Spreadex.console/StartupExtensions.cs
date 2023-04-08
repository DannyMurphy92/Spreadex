using Microsoft.Extensions.DependencyInjection;
using Spreadex.console.services;
using Spreadex.console.services.factories;
using Spreadex.console.services.factories.interfaces;
using Spreadex.console.services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spreadex.console;
public static class StartupExtensions
{
    public static IServiceCollection AddSpeadexConsoleServices(this IServiceCollection services)
    {
        return services.AddScoped<IConsoleProvider, ConsoleProvider>()
            .AddScoped<IWidgetFactory, WidgetFactory>()
            .AddScoped<IApplication, Application>();
    }
}
