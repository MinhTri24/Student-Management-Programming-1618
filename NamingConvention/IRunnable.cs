using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamingConvention
{
    // Interface name: begin with I + PascalCase
    public interface IRunnable
    {
        // Method name: PascalCase
        void Run();
        void SleepWalker();
    }
}
