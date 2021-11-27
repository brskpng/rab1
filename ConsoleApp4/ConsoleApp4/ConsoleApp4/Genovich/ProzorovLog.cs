using System;
using System.Collections.Generic;
using System.Text;
using core;

namespace Genovich
{
    class GenovichLog : LogAbstract, LogInterface
    {
        private static GenovichLog instance = null;
        static List<String> logs = new List<string>();

        public static GenovichLog getIntance()
        {
            if (instance == null)
                instance = new GenovichLog();
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
