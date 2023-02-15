using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temporizador.Properties;

namespace Temporizador
{
    public partial class Form3 : Form
    {
        internal bool bucleSonido;
        private SoundPlayer sonido;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public Form3()
        {
            InitializeComponent();  
            
        }

        public SoundPlayer Sonido { get => sonido; set => sonido = value; }

        private void reproducirSonido()
        {
            if (bucleSonido)
            {
                Sonido.PlayLooping();
            }
            else
            {
                Sonido.Play(); 
            }
        }

        private void btnFinalizadoReiniciar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 padre = (Form1)this.Owner;
            padre.ReiniciarTemporizador();

        }


        private void btnFinalizadoCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form3_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                reproducirSonido();
            }
            else
            {
                Sonido.Stop();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
