using Microsoft.Extensions.Configuration;
using Serilog;


namespace Plantilla.Common.Layer.Adaptarse
{
    public class LoggerAdapterSeriLog : ILoggerAdapter
    {

        public LoggerAdapterSeriLog()
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(configuration).CreateLogger();
        }

        public void Debug(string message)
        {
            Log.Debug(message);
            Log.Information("dsfdsfdsf");
            Log.CloseAndFlush();
        }

        public void Error(string message)
        {
            Log.Error(message);
            Log.Information("dsfdsfdsf");
            Log.CloseAndFlush();

        }

        public void Info(string message)
        {
            Log.Information(message);
            Log.Information("dsfdsfdsf");
            Log.CloseAndFlush();


        }

        public void Warning(string message)
        {
            Log.Warning(message);
            Log.Information("dsfdsfdsf");
            Log.CloseAndFlush();

        }
    }
}
