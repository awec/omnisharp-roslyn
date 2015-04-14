using OmniSharp.Services;
using Microsoft.Framework.Logging;

namespace OmniSharp.Tests
{
    public class FakeEnvironment : IOmnisharpEnvironment
    {
        public LogLevel TraceType { get; }
        public int Port { get; }
        public int HostPID { get; }
        public string Path { get { return "."; } }
        public string SolutionFilePath { get; }
        public TransportType TransportType { get; }
    }
}