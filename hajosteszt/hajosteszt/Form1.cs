namespace hajosteszt
{
    public partial class Form1 : Form
    {
        List<kerdes> �sszesk�rd�s;
        List<kerdes> aktualiskerdesek;
        int Megjelen�tettk�rd�ssz�ma = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            �sszesk�rd�s = kerdesekbetoltese();
            aktualiskerdesek = new List<kerdes>();

            for (int i = 0; i < 7; i++)
            {
                aktualiskerdesek.Add(�sszesk�rd�s[0]);
                �sszesk�rd�s.RemoveAt(0);
            }
            dataGridView1.DataSource = aktualiskerdesek;
            K�rd�sMegjelen�t�s(aktualiskerdesek[Megjelen�tettk�rd�ssz�ma]);
        }

        List<kerdes> kerdesekbetoltese()
        {
            List<kerdes> kerdesek = new List<kerdes>();
            StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
            while (!sr.EndOfStream)
            {

                string sor = sr.ReadLine();
                string[] t�mb = sor.Split("\t");

                if (t�mb.Length != 7) continue;

                kerdes k = new kerdes();
                k.K�rd�sSz�veg = t�mb[1].ToUpper();
                k.V�lasz1 = t�mb[2].Trim('"');
                k.V�lasz2 = t�mb[3].Trim('"');
                k.V�lasz3 = t�mb[4].Trim('"');
                k.URL = t�mb[5];

                int x = 0;
                int.TryParse(t�mb[6], out x);
                k.HelyesV�lasz = x;

                kerdesek.Add(k);

            }

            sr.Close();
            return kerdesek;
        }

        void K�rd�sMegjelen�t�s(kerdes k�rd�s)
        {
            label1.Text = k�rd�s.K�rd�sSz�veg;
            textBox1.Text = k�rd�s.V�lasz1;
            textBox2.Text = k�rd�s.V�lasz2;
            textBox3.Text = k�rd�s.V�lasz3;
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;

            if (string.IsNullOrEmpty(k�rd�s.URL))
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + k�rd�s.URL);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Megjelen�tettk�rd�ssz�ma++;
            if (Megjelen�tettk�rd�ssz�ma == 7) Megjelen�tettk�rd�ssz�ma = 0;

            K�rd�sMegjelen�t�s(aktualiskerdesek[Megjelen�tettk�rd�ssz�ma]);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
            Sz�nez�s();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Red;
            Sz�nez�s();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Red;
            Sz�nez�s();
        }

        void Sz�nez�s() 
        {
            int helyesV�lasz = aktualiskerdesek[Megjelen�tettk�rd�ssz�ma].HelyesV�lasz;
            if(helyesV�lasz==1) textBox1.BackColor= Color.LightGreen;
            if (helyesV�lasz == 2) textBox2.BackColor = Color.LightGreen;
            if (helyesV�lasz == 3) textBox3.BackColor = Color.LightGreen;
        }
    }
}