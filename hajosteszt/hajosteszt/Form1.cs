namespace hajosteszt
{
    public partial class Form1 : Form
    {
        List<kerdes> Összeskérdés;
        List<kerdes> aktualiskerdesek;
        int Megjelenítettkérdésszáma = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Összeskérdés = kerdesekbetoltese();
            aktualiskerdesek = new List<kerdes>();

            for (int i = 0; i < 7; i++)
            {
                aktualiskerdesek.Add(Összeskérdés[0]);
                Összeskérdés.RemoveAt(0);
            }
            dataGridView1.DataSource = aktualiskerdesek;
            KérdésMegjelenítés(aktualiskerdesek[Megjelenítettkérdésszáma]);
        }

        List<kerdes> kerdesekbetoltese()
        {
            List<kerdes> kerdesek = new List<kerdes>();
            StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
            while (!sr.EndOfStream)
            {

                string sor = sr.ReadLine();
                string[] tömb = sor.Split("\t");

                if (tömb.Length != 7) continue;

                kerdes k = new kerdes();
                k.KérdésSzöveg = tömb[1].ToUpper();
                k.Válasz1 = tömb[2].Trim('"');
                k.Válasz2 = tömb[3].Trim('"');
                k.Válasz3 = tömb[4].Trim('"');
                k.URL = tömb[5];

                int x = 0;
                int.TryParse(tömb[6], out x);
                k.HelyesVálasz = x;

                kerdesek.Add(k);

            }

            sr.Close();
            return kerdesek;
        }

        void KérdésMegjelenítés(kerdes kérdés)
        {
            label1.Text = kérdés.KérdésSzöveg;
            textBox1.Text = kérdés.Válasz1;
            textBox2.Text = kérdés.Válasz2;
            textBox3.Text = kérdés.Válasz3;
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;

            if (string.IsNullOrEmpty(kérdés.URL))
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + kérdés.URL);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Megjelenítettkérdésszáma++;
            if (Megjelenítettkérdésszáma == 7) Megjelenítettkérdésszáma = 0;

            KérdésMegjelenítés(aktualiskerdesek[Megjelenítettkérdésszáma]);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
            Színezés();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Red;
            Színezés();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Red;
            Színezés();
        }

        void Színezés() 
        {
            int helyesVálasz = aktualiskerdesek[Megjelenítettkérdésszáma].HelyesVálasz;
            if(helyesVálasz==1) textBox1.BackColor= Color.LightGreen;
            if (helyesVálasz == 2) textBox2.BackColor = Color.LightGreen;
            if (helyesVálasz == 3) textBox3.BackColor = Color.LightGreen;
        }
    }
}