using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Interfaces;

namespace Writter_Kata.Factory {
    public static class WriterFactory {
        private static readonly Dictionary<string, IWriter> WriterCreators = new Dictionary<string, IWriter>();
        public static IWriter CreateWriter(string Tipo) {
            return WriterCreators[Tipo];
        }
    }
}
