using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Writter_Kata.Interfaces;

namespace Writter_Kata.Factory {
    class WriterTxt : IWriter {
        public void WriteFile(string fileName) {
            using(StreamWriter sw = new StreamWriter(fileName + ".txt")) {               
                    sw.WriteLine("C:\\");
            }
        }
    }
}
