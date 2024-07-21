namespace stajornek10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random zar = new Random();
        int toplam1, toplam2;

        private void button1_Click(object sender, EventArgs e)
        {
            int a = zar.Next(1, 7);
            int b = zar.Next(1, 7);
            lbl1zar1.Text = a.ToString();
            lbl1zar2.Text = b.ToString();

            int zar1 = Convert.ToInt32(lbl1zar1.Text);
            int zar2 = Convert.ToInt32(lbl1zar2.Text);
            toplam1 = toplam1 + zar1 + zar2;
            lbl1toplam.Text = toplam1.ToString();
            btn2.Enabled = true;
            btn1.Enabled = false;

            if (toplam1 >= 100)
            {
                lblkazanan.Text = "1. Oyuncu Kazandý!";
                btntekrar.Visible = true;
            }


        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int a = zar.Next(1, 7);
            int b = zar.Next(1, 7);
            lbl2zar1.Text = a.ToString();
            lbl2zar2.Text = b.ToString();

            int zar1 = Convert.ToInt32(lbl2zar1.Text);
            int zar2 = Convert.ToInt32(lbl2zar2.Text);
            toplam2 = toplam2 + zar1 + zar2;
            lbl2toplam.Text = toplam2.ToString();
            btn1.Enabled = true;
            btn2.Enabled = false;

            if (toplam2 >= 100)
            {
                lblkazanan.Text = "2. Oyuncu Kazandý!";
                btntekrar.Visible = true;
            }
        }

        private void btntekrar_Click(object sender, EventArgs e)
        {
            lbl1zar1.Text = "0";
            lbl1zar2.Text = "0";
            lbl2zar1.Text = "0";
            lbl2zar2.Text = "0";

            lbl1toplam.Text = "0";
            lbl2toplam.Text = "0";
            toplam1 = 0;
            toplam2 = 0;

            lblkazanan.Text = "";
            btntekrar.Visible = false;

        }
    }
}