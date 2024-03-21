using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kigyo
{
    internal class kaja :PictureBox
    {
        public static int Méret = 20;

        public kaja()
        {
            Width = KigyoElem.Méret;
            Height = KigyoElem.Méret;
            BackColor = Color.Red;
        }
    }
}
