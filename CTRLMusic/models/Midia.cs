
using System.Runtime.CompilerServices;

namespace CTRLMusic.models
{
    public class Midia : Product
    {
        // PROPERTIES

        public string Genres { get; set; }
        public string Artist { get; set; }
        public string Duration { get; set; }
        public string Languages { get; set; }
        public Measures Measures { get; set; }

        // CONSTRUCTORS

        public Midia(){}
    }
}
