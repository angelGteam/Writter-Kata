using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Writter_Kata.Services {
    public class Contenedor {
        public static IServiceProvider Build() {
            var Container = new ServiceCollection() //.Scoped, .Singleton, .Transient
                .AddSingleton<IWritter, WriteManager>();                
            return Container.BuildServiceProvider();
        }
    }
}
