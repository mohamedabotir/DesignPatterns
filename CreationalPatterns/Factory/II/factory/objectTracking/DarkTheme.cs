using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace factory.objectTracking
{
    public class DarkTheme : ITheme
    {
        public string TextColor => "white";
        public string BgrColor => "dark gray";
    }
}