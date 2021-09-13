using System;
using Writter_Kata.Models;
using Writter_Kata.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Writter_Kata {
    class Program {
        static void Main(string[] args) {
            var ContainerProvider = Contenedor.Build();
            var WriteManager = ContainerProvider.GetService<IWritter>();
            string Type;
            int Environment=2;
            while(true) {
                while(Environment != 0 && Environment != 1) {
                    Console.WriteLine(@"Introduce the environment:
local = 0,
cloud = 1"
);
                    Environment = int.Parse(Console.ReadLine());
                }

                Console.WriteLine(@"Introduce the type of file to create:
json,
xml,
yml,
txt
                    ");
                Type = Console.ReadLine();
                if(Enum.TryParse(Type, out FileType fileType)) {
                    switch(Type) {
                    case "json":
                    WriteManager.Write("FicheroJson", FileType.json, (EnvironmentType)Environment);
                    break;
                    case "xml":
                    WriteManager.Write("FicheroXml", FileType.xml, (EnvironmentType)Environment);
                    break;
                    case "yml":
                    WriteManager.Write("FicheroAyml", FileType.yml, (EnvironmentType)Environment);
                    break;
                    case "txt":
                    WriteManager.Write("FicheroTxt", FileType.txt, (EnvironmentType)Environment);
                    break;
                    }
                }
                Environment = 2;
            }
        }
    }
}