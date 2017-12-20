using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton
    {
        private static readonly Singleton Instance = new Singleton();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit

        static Singleton() { }

        private Singleton(){}

        public static Singleton GetInstance()
        {
            return Instance;
        }

    }
}
