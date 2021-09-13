using System.IO;
using Writter_Kata.Interfaces;

namespace Writter_Kata.Factory {
    class XmlFormatter : IFormatter {
        public void WriteFile(string fileName) {
            StreamWriter StreamWriter = new StreamWriter("C:\\" + fileName + ".xml");          
        }
    }
}
