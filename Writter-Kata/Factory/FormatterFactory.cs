using System.Collections.Generic;
using Writter_Kata.Interfaces;
using Writter_Kata.Models;

namespace Writter_Kata.Factory {
    public static class FormatterFactory {
        private static readonly Dictionary<FileType, IWriter> WriterCreators = new Dictionary<FileType, IWriter>{
            { FileType.txt, new TxtFormatter() },
            { FileType.xml, new XmlFormatter() },
            { FileType.ayml, new AymlFormatter() },
            { FileType.json, new JsonFormatter() }
        };
        public static IWriter CreateWriter(FileType type) {
            return WriterCreators[type];
        }
    }
}
