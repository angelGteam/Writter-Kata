using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Factory;
using Writter_Kata.Interfaces;
using Writter_Kata.Models;

namespace Writter_Kata.Services {
    public class WriteManager {
        public static void Write(string fileName, FileType extension) {
            IWriter writer = FormatterFactory.CreateWriter(extension);
            writer.WriteFile(fileName);
        }
    }
}