using Writter_Kata.Models;
using Writter_Kata.Services;
using Xunit;

namespace Writter_Kata.Tests {
    public class WriterShould {
        [Fact]
        public void TestJsonCreation() {
            WriteManager.StaticWrite("FicheroJson", FileType.json, 0);
        }
        [Fact]
        public void TestXmlCreation() {
            WriteManager.StaticWrite("FicheroXml", FileType.xml, 0);
        }
        [Fact]
        public void TestAymlCreation() {
            WriteManager.StaticWrite("FicheroAyml", FileType.yml, 0);
        }
        [Fact]
        public void TestTxtCreation() {
            WriteManager.StaticWrite("FicheroTxt", FileType.txt, 0);
        }
    }
}
