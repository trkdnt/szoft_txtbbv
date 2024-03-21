using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kigyo
{
    internal class KigyoElem:PictureBox
    {
        public static int Méret = 20;
        public static int hossz = 10;
        public KigyoElem()
        {
            Width = KigyoElem.Méret;
            Height = KigyoElem.Méret;
            BackColor = Color.LightGreen;
        }
    }
}
