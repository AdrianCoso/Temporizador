using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temporizador
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            rbCuenta.Checked = true;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1.sonidos[(string)cbSonidos.SelectedItem].Play();
        }

        private void rbCuenta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCuenta.Checked)
            {
                pnlFecha.Hide();
                pnlCuenta.Show();
            }
            else
            {
                pnlCuenta.Hide();
                pnlFecha.Show();
            }
        }
    }

}
