using Microsoft.Extensions.DependencyInjection;
using PetShop.core.Domain;
using PetShop.core.Service;
using PetShop.core.Service.Implementation;
using PetShop.inferstuture.Static.data;
using PetShop.inferstuture.Static.data.Repositories;
using System;

namespace PetShop
{
    class MainView
    {

        static void Main(string[] args)
        {

            database.DataStart();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<IPetRep,PetRepository>();
            serviceCollection.AddScoped<IPrinter, Printer>();
            serviceCollection.AddScoped<IPetService,PetService>();

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var Printer = serviceProvider.GetRequiredService<IPrinter>();
            Printer.StartUI();

        }
    }
}
