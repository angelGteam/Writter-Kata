﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Writter_Kata.Interfaces;

namespace Writter_Kata.Factory {
    class TxtFormatter : IWriter {
        public void WriteFile(string fileName) {
            using(StreamWriter streamWriter = new StreamWriter("C:\\" + fileName + ".txt")) {
            }
        }
    }
}