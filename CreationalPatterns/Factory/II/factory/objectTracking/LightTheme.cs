using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using factory.objectTracking;

namespace factory.objectTracking
{
    public class LightTheme : ITheme
    {
        public string TextColor => "black";

        public string BgrColor => "white";
    }
}