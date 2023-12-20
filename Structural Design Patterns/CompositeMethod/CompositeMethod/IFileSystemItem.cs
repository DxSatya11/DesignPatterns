using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMethod
{
    // Component interface
    public interface IFileSystemItem
    {
        string Name { get; }
        int GetSize();
    }
}
