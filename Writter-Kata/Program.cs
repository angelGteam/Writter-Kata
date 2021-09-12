using System;
using Writter_Kata.Models;
using Writter_Kata.Services;

namespace Writter_Kata {
    class Program {
        static void Main(string[] args) {
            string type;
            while(true) {
                Console.WriteLine(@"Introduce el tipo de archivo que quieres crear
json,
xml,
ayml,
txt,
                    ");
                type = Console.ReadLine();
                if(Enum.TryParse(type, out FileType fileType)) {
                    switch(type) {
                    case "json":
                    WriteManager.Write("FicheroJson", FileType.json);
                    break;
                    case "xml":
                    WriteManager.Write("FicheroXml", FileType.xml);
                    break;
                    case "ayml":
                    WriteManager.Write("FicheroAyml", FileType.ayml);
                    break;
                    case "txt":
                    WriteManager.Write("FicheroTxt", FileType.txt);
                    break;
                    }
                }
            }
        }
    }
}