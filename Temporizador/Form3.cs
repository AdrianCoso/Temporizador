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
        private SoundPlayer sonido;
        public Form3()
        {
            InitializeComponent();
           
        }

        public SoundPlayer Sonido { get => sonido; set => sonido = value; }

        private void reproducirSonido(object sender, EventArgs e)
        {
            Sonido.Play();
        }
    }
}
