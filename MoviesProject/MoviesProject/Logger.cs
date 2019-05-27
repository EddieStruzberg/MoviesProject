using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace MoviesProject
{
    public class Logger
    {
        public static void WriteLog(string LogMessage, EventLogEntryType Type)
        {
            EventLog.WriteEntry(".NET Runtime",LogMessage,Type,1000);
        }
    }
}