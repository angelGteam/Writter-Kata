using System.Collections.Generic;
using Writter_Kata.Interfaces;
using Writter_Kata.Models;

namespace Writter_Kata.Factory {
    public static class FormatterFactoryLocal {
        private static readonly Dictionary<FileType, IFormatter> WriterCreators = new Dictionary<FileType, IFormatter>{
            { FileType.txt, new TxtFormatter() },
            { FileType.xml, new XmlFormatter() },
            { FileType.yml, new YmlFormatter() },
            { FileType.json, new JsonFormatter() }
        };
        public static IFormatter CreateWriter(FileType type) {
            return WriterCreators[type];
        }
    }
}
