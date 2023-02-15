using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temporizador
{
    public partial class Form2 : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public Form2()
        {
            InitializeComponent();
            rbCuenta.Checked = Form1.cuenta; // Seleccionamos el modo del editor Fecha/Cuenta atrás
            
        }

        /**
         * Reproduce el sonido seleccionado en el ComboBox al hacer click en la imagen
         */
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1.sonidos[(string)cbSonidos.SelectedItem].Play();
        }

        /**
         * Cambia el modo del editor dependiendo de la opción escogida
         */
        private void rbCuenta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCuenta.Checked)
            {
                pnlFecha.Hide();
                this.Height = 323;
                pnlCuenta.Show();
            }
            else
            {
                pnlCuenta.Hide();
                this.Height = 267;
                pnlFecha.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }

}
