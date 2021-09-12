using System.IO;
using Writter_Kata.Interfaces;

namespace Writter_Kata.Factory {
    class AymlFormatter : IWriter {
        public void WriteFile(string fileName) {
            StreamWriter streamWriter = new StreamWriter("C:\\" + fileName + ".Ayml");
            }
        }
    }
}
