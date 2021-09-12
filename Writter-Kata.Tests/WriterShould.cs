using Writter_Kata.Models;
using Writter_Kata.Services;
using Xunit;

namespace Writter_Kata.Tests {
    public class WriterShould {
        [Fact]
        public void TestJsonCreation() {
            WriteManager.Write("FicheroJson", FileType.json);
        }
        [Fact]
        public void TestXmlCreation() {
            WriteManager.Write("FicheroXml", FileType.xml);
        }
        [Fact]
        public void TestAymlCreation() {
            WriteManager.Write("FicheroAyml", FileType.ayml);
        }
        [Fact]
        public void TestTxtCreation() {
            WriteManager.Write("FicheroTxt", FileType.txt);
        }

    }
}
