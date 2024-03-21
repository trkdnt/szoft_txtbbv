namespace kigyo
{
    public partial class Form1 : Form
    {
        int fej_x;
        int fej_y;
        int ir�ny_x;
        int ir�ny_y;
        int L�pesSz�m;
        List<KigyoElem> kigyo = new List<KigyoElem>();
        public Form1()
        {
            InitializeComponent();
            fej_x = 100;
            fej_y = 100;
            ir�ny_x = 1;
            ir�ny_y = 0;
            L�pesSz�m = 0;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            L�pesSz�m++;

            if (L�pesSz�m%4==0)
            {
                kaja kaja = new kaja();
                kaja.Top =L�pesSz�m*20;
                kaja.Left = L�pesSz�m*20;
                Controls.Add(kaja);
            }
            foreach (object item in Controls)
            {
                if (item is kaja)
                {
                    kaja k = (kaja)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        KigyoElem.hossz++;
                    }
                }
            }

            //Fejn�veszt�s
            fej_x += ir�ny_x * KigyoElem.M�ret;
            fej_y += ir�ny_y * KigyoElem.M�ret;
            foreach (object item in Controls)
            {
                if (item is KigyoElem)
                {
                    KigyoElem k = (KigyoElem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }
            if (Controls.Count > KigyoElem.hossz)
                {
                    KigyoElem lev�gand� = kigyo[0];
                    kigyo.RemoveAt(0);
                    Controls.Remove(lev�gand�);
                }


            

            KigyoElem ke = new KigyoElem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            Controls.Add(ke);
            kigyo.Add(ke);
            if (L�pesSz�m % 2 == 0) ke.BackColor = Color.Green;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ir�ny_y = -1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                ir�ny_y = 1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                ir�ny_y = 0;
                ir�ny_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                ir�ny_y = 0;
                ir�ny_x = 1;
            }
        }

    }
}