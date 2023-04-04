using System.Diagnostics.Eventing.Reader;

namespace bilgiyarısması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno, dogru, yanlıs = 0;
        private void btnsonra_Click(object sender, EventArgs e)
        {


            btna.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled = true;
            btnd.Enabled = true;
            btnsonra.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruno = soruno + 1;
            lblsoruno.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi klavyeden giriş yapmak istediğimizde kullandığımız araçtır?";
                btna.Text = "Button";
                btnb.Text = "TextBox";
                btnc.Text = "ComboBox";
                btnd.Text = "Label";
                label4.Text = "TextBox";

            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Formun arka rengini kırmızı yapan kod hangisidir?";
                btna.Text = "this.Text = \"Merhaba\"";
                btnb.Text = "button2.Visible = true; ";
                btnc.Text = "this.BackColor = Color.Red;";
                btnd.Text = "button2.Text = \"Kırmızı\"";
                label4.Text = "this.BackColor = Color.Red;";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisinde değişken tanımlama kurallarına uyulmayıp yanlış değişken\r\ntanımlanmıştır?";
                btna.Text = "string Ad1;";
                btnb.Text = "float y;";
                btnc.Text = "double x;";
                btnd.Text = "int true;";
                label4.Text = "int true;";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Sayısal bir ifadeyi label1 de yazdırabilmek için hangisi kullanılır ?";
                btna.Text = "ToLower()";
                btnb.Text = "ToString()";
                btnc.Text = "Trim()";
                btnd.Text = "ToUpper()";
                label4.Text = "ToString()";
            }
            if (soruno == 4)
            {

                richTextBox1.Text = "Aşağıdakilerden hangisi C# 'da bir yorum (comment) yazmayı doğru göstermiştir.";
                btna.Text = "#";
                btnb.Text = "//";
                btnc.Text = "/*";
                btnd.Text = "/!";
                label4.Text = "//";
            }

        }

        private void btna_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonra.Enabled = true;

            label5.Text = btna.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldoru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlıs++;
                lblyanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;


            }
        }

        private void btnb_Click(object sender, EventArgs e)
        {

            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonra.Enabled = true;
            label5.Text = btnb.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldoru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlıs++;
                lblyanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;


            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonra.Enabled = true;

            label5.Text = btnc.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldoru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlıs++;
                lblyanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;


            }
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonra.Enabled = true;
            label5.Text = btnd.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldoru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlıs++;
                lblyanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;


            }
        }
    }
}
