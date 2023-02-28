using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeygirGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int birinciatsoluzaklik, ikinciatsoluzaklik, ucuncuatsoluzaklik;

        Random rastgele = new Random();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsoluzaklik = pictureBox1.Left;
            ikinciatsoluzaklik = pictureBox2.Left;
            ucuncuatsoluzaklik = pictureBox3.Left;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int derece = Convert.ToInt32(label7.Text);
            derece++;
            label7.Text = derece.ToString();

            int birinciatgenisligi = pictureBox1.Width;
            int ikinciatgenisligi = pictureBox2.Width;
            int ucuncuatgenisligi = pictureBox3.Width;

            int bitisuzakligi = label5.Left;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 15);

            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label6.Text = "1 Numaralı At yarışı önde götürüyor";
            }

            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "2 Numaralı At iyi bir atakla öne geçiyor";
            }

            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                label6.Text = "3 Numaralı At liderliği aldı";
            }

            if (birinciatgenisligi + pictureBox1.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;

                label6.Text = "1 Numaralı At Yarışı Kazandı !!!";
            }

            if (ikinciatgenisligi + pictureBox2.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;

                label6.Text = "2 Numaralı At Yarışı Kazandı !!!";
            }

            if (ucuncuatgenisligi + pictureBox3.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;

                label6.Text = "3 Numaralı At Yarışı Kazandı !!!";            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
