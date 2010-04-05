using System;
using System.Diagnostics;
using OpenRasta.Diagnostics;

namespace Britannic.Web.Infrastructure
{
    public class DebugLogger : ILogger
    {
        public IDisposable Operation(object source, string name)
        {
            Debug.WriteLine(source + " " + name);
            return null;
        }

        public void WriteDebug(string message, params object[] format)
        {
            Debug.WriteLine(message, format);
        }

        public void WriteWarning(string message, params object[] format)
        {
            Debug.WriteLine(message, format);
        }

        public void WriteError(string message, params object[] format)
        {
            Debug.WriteLine(message, format);
        }

        public void WriteInfo(string message, params object[] format)
        {
            Debug.WriteLine(message, format);
        }

        public void WriteException(Exception e)
        {
            Debug.WriteLine(e.Message);
        }
    }
}