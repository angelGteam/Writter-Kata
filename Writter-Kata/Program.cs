﻿using System;
using System.IO;

namespace Writter_Kata {
    class Program {
        static void Main(string[] args) {
            DirectoryInfo[] cDirs = new DirectoryInfo(@"c:\").GetDirectories();
            // Write each directory name to a file.
            using(StreamWriter sw = new StreamWriter("CDriveDirs.txt")) {
                foreach(DirectoryInfo dir in cDirs) {
                    sw.WriteLine(dir.Name);
                }
            }
            // Read and show each line from the file.
            string line = "";
            using(StreamReader sr = new StreamReader("CDriveDirs.txt")) {
                while((line = sr.ReadLine()) != null) {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
