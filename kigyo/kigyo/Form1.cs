namespace kigyo
{
    public partial class Form1 : Form
    {
        int fej_x;
        int fej_y;
        int irány_x;
        int irány_y;
        int LépesSzám;
        List<KigyoElem> kigyo = new List<KigyoElem>();
        public Form1()
        {
            InitializeComponent();
            fej_x = 100;
            fej_y = 100;
            irány_x = 1;
            irány_y = 0;
            LépesSzám = 0;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            LépesSzám++;

            if (LépesSzám%4==0)
            {
                kaja kaja = new kaja();
                kaja.Top =LépesSzám*20;
                kaja.Left = LépesSzám*20;
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

            //Fejnövesztés
            fej_x += irány_x * KigyoElem.Méret;
            fej_y += irány_y * KigyoElem.Méret;
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
                    KigyoElem levágandó = kigyo[0];
                    kigyo.RemoveAt(0);
                    Controls.Remove(levágandó);
                }


            

            KigyoElem ke = new KigyoElem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            Controls.Add(ke);
            kigyo.Add(ke);
            if (LépesSzám % 2 == 0) ke.BackColor = Color.Green;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irány_y = -1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                irány_y = 1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                irány_y = 0;
                irány_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                irány_y = 0;
                irány_x = 1;
            }
        }

    }
}