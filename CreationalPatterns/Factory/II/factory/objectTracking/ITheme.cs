using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace factory.objectTracking
{
    public interface ITheme
    {
        string TextColor { get; }
        string BgrColor { get; }
    }
}