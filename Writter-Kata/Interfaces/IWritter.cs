using Writter_Kata.Models;

namespace Writter_Kata.Services {
    public interface IWritter {
        void Write(string fileName, FileType extension, EnvironmentType environment);
    }
}