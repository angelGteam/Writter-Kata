using Writter_Kata.Models;
using Writter_Kata.Services;
using Xunit;

namespace Writter_Kata.Tests {
    public class WriterShould {
        [Fact]
        public void Test1() {
            WriteManager.Write("Prueba", FileType.txt);
        }
    }
}
