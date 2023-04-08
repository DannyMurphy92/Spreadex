// See https://aka.ms/new-console-template for more information


using Microsoft.Extensions.DependencyInjection;
using Spreadex.console;
using Spreadex.console.models;
using Spreadex.console.services.factories;
using Spreadex.console.services.interfaces;
using System.Drawing;

var servicesProvider = new ServiceCollection()
    .AddSpeadexConsoleServices()
    .BuildServiceProvider();

var application = servicesProvider.GetService<IApplication>();

application!.Run();
