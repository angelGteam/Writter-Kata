using System.IO;
using Writter_Kata.Interfaces;

namespace Writter_Kata.Factory {
    class XmlFormatter : IWriter {
        public void WriteFile(string fileName) {
            StreamWriter streamWriter = new StreamWriter("C:\\" + fileName + ".xml");          
        }
    }
}
