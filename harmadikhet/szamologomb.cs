using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmadikhet
{
    internal class szamologomb : Villogogomb
    {
        int szám = 1;
        public szamologomb()
        {
            Height = 20;
            Width = 20;
            Text = szám.ToString();
            MouseClick += Szamologomb_MouseClick; ;
        }

        private void Szamologomb_MouseClick(object? sender, MouseEventArgs e)
        {

            Text = szám++.ToString();
            if (szám > 6)
            {
                szám = 1;
            }
        }
    }
}
