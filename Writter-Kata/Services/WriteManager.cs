using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Factory;
using Writter_Kata.Interfaces;

namespace Writter_Kata.Services {
    public class WriteManager {
        public static void Write(string extension, string fileName) {
            IWriter writer = WriterFactory.CreateWriter(extension);
            writer.Write(fileName);
        }
    }
}