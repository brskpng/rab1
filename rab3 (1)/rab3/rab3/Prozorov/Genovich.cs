using core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genovich
{
    class Genovich : LogAbstract, LogInterface
    {

        private static Genovich instance = null;
        static List<String> logs = new List<string>();

        public static Genovich getIntance()
        {
            if (instance == null)
                instance = new Genovich();
            return instance;
        }
        public LogInterface log(string str)
        {
            logs.Add(str);
            return this;
        }

        public LogInterface write()
        {
            writeConsole(logs.ToArray());
            return this;
        }
    }
}
