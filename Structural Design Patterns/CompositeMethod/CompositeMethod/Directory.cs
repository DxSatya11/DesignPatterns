using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMethod
{
    // Composite class - represents a directory
    public class Directory : IFileSystemItem
    {
        public string Name { get; }
        private List<IFileSystemItem> items = new List<IFileSystemItem>();
        public Directory(string name)
        {
            Name = name;
        }
        public void AddItem(IFileSystemItem item)
        {
            items.Add(item);
        }

        public void RemoveItem(IFileSystemItem item)
        {
            items.Remove(item);
        }
        public int GetSize()
        {
            int totalSize = 0;
            foreach (var item in items)
            {
                totalSize += item.GetSize();
            }
            return totalSize;
        }
    }
}
