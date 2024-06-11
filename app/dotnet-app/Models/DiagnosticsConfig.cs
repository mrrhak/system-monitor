using System.Diagnostics;

namespace dotnet_app.Models
{
    public static class DiagnosticsConfig
    {
        public const string ServiceName = "dotnet-app";
        public const string ServiceVersion = "1.0.0";
        public readonly static ActivitySource ActivitySource = new(ServiceName);
    }
}