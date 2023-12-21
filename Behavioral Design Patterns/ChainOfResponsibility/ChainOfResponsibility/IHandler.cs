using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    // Handler interface
    public interface IHandler
    {
        IHandler NextHandler { get; set; }
        void HandleRequest(int request);
    }
}
