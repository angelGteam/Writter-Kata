using System.IO;
using Writter_Kata.Interfaces;

namespace Writter_Kata.Factory {
    class YmlFormatter : IFormatter {
        public void WriteFile(string fileName) {
            StreamWriter StreamWriter = new StreamWriter("C:\\" + fileName + ".Yml");
            
        }
    }
}
