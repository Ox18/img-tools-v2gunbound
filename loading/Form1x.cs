using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImgTools;
namespace loading
{
    public partial class Form1x : Form
    {
        public Form1x()
        {
            InitializeComponent();
        }

        private void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            panel2.Width += 2;
            txtPorcentaje.Text = (panel2.Width * 100 / 620) + "%";
            if (panel2.Width >= 600)
            {
                timer1.Stop();
                Form1 fm = new Form1();
                this.Hide();
                fm.ShowDialog();
                this.Close();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
