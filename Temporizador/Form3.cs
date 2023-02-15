using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
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
        public Form3()
        {
            InitializeComponent();

            
            
        }

        public SoundPlayer Sonido { get => sonido; set => sonido = value; }

        private void reproducirSonido(object sender, EventArgs e)
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

        private void btnFinalizadoCancelar_Paint(object sender, PaintEventArgs e)
        {
            reproducirSonido(sender, e);
        }

        private void Form3_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                reproducirSonido(sender, e);
            }
            else
            {
                Sonido.Stop();
            }
        }
    }
}
