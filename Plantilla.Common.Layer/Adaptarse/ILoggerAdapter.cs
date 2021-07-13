using System;
using System.Collections.Generic;
using System.Text;

namespace Plantilla.Common.Layer.Adaptarse
{
    public interface ILoggerAdapter
    {
        void Debug(string message);
        void Info(string message);
        void Error(string message);
        void Warning(string message);
    }
}
