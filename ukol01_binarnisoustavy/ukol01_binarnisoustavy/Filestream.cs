using System.IO;

namespace ukol01_binarnisoustavy
{
    internal class Filestream : FileStream
    {
        public Filestream(string path, FileMode mode, FileAccess access) : base(path, mode, access)
        {
        }
    }
}