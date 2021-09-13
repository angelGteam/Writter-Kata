using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Factory;
using Writter_Kata.Interfaces;
using Writter_Kata.Models;

namespace Writter_Kata.Services {
    public class WriteManager : IWritter {
        public void Write(string fileName, FileType extension, EnvironmentType environment ) {
            if(environment == 0) {
                IFormatter LocalWriter = FormatterFactoryLocal.CreateWriter(extension);
                LocalWriter.WriteFile(fileName);
            }
            IFormatter CloudWriter = FormatterFactoryCloud.CreateWriter(extension);
            CloudWriter.WriteFile(fileName);
        }
        public static void StaticWrite(string fileName, FileType extension, EnvironmentType environment) {
            if(environment == 0) {
                IFormatter LocalWriter = FormatterFactoryLocal.CreateWriter(extension);
                LocalWriter.WriteFile(fileName);
            }
            IFormatter CloudWriter = FormatterFactoryCloud.CreateWriter(extension);
            CloudWriter.WriteFile(fileName);
        }
    }
}