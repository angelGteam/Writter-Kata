using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Interfaces;
using Writter_Kata.Models;

namespace Writter_Kata.Factory {
    public static class WriterFactory {
        private static readonly Dictionary<FileType, IWriter> WriterCreators = new Dictionary<FileType, IWriter>{
            { FileType.txt, new WriterTxt() },
            { FileType.xml, new WriterXml() },
            { FileType.ayml, new WriterAyml() },
            { FileType.json, new WriterJson() }
        };
        public static IWriter CreateWriter(FileType type) {
            return WriterCreators[type];
        }
    }
}
