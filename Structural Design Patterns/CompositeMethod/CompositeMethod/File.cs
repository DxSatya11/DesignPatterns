using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMethod
{
    // Leaf class - represents a file
    public class File : IFileSystemItem
    {
        public string Name { get; }
        private int size;

        public File(string name, int size)
        {
            Name = name;
            this.size = size;
        }
        public int GetSize()
        {
            return size;
        }
    }
}
