using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temporizador
{
    public partial class Form1 : Form
    {

        int horas;
        int minutos;
        int segundos;
        DateTime tiempoInicial;
        TimeSpan tiempoParaMostrar;
        TimeSpan tiempoContador;
        TimeSpan intervalo;
        public Form1()
        {
            InitializeComponent();
            InitCustomFont();
            horas = 0;
            minutos = 4;
            segundos = 0;
            tiempoContador = new TimeSpan(horas, minutos, segundos);
            
            lblTiempo.Text = tiempoContador.ToString(@"hh\:mm\:ss");
            
        }

        private void InitCustomFont()
        {
            // Crear una colección privada de fuentes
            PrivateFontCollection pfc = new PrivateFontCollection();

            // Seleccionar la fuente de los recursos disponibles
            // La fuente se llama "Digital_7_mono"
            int fontLength = Properties.Resources.digital_7__mono_.Length;

            // Crear un buffer del que leer
            byte[] fontdata = Properties.Resources.digital_7__mono_;

            // Crear un bloque de memoria no seguro para los datos de la fuente
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // Copiar los bytes al bloque de memoria
            Marshal.Copy(fontdata, 0, data, fontLength);

            // Pasar la fuente a la colección privada 
            pfc.AddMemoryFont(data, fontLength);
            lblTiempo.Font = new Font(pfc.Families[0], lblTiempo.Font.Size);
        }

        private void btnIniciarParar_Click(object sender, EventArgs e)
        {
            if (btnIniciarParar.Text == "Iniciar")
            {
                tiempoInicial = DateTime.Now;
                timer1.Enabled = true;
                btnIniciarParar.Text = "Pausar";

            }
            else
            {
                tiempoContador = tiempoParaMostrar;
                timer1.Enabled = false;
                btnIniciarParar.Text = "Iniciar";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            intervalo = DateTime.Now - tiempoInicial;
            
            tiempoParaMostrar = tiempoContador.Subtract(intervalo);
            if (tiempoParaMostrar.CompareTo(TimeSpan.Zero) <= 0)
            {
                timer1.Enabled = false;
                Form3 dialogoFinalizacion = new Form3();
                if(dialogoFinalizacion.ShowDialog(this) == DialogResult.OK)
                {
                    ReiniciarTemporizador();
                }
            }
            lblTiempo.Text = tiempoParaMostrar.ToString(@"hh\:mm\:ss");

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            ReiniciarTemporizador();
        }

        private void ReiniciarTemporizador()
        {
            timer1.Enabled = false;
            tiempoContador = new TimeSpan(horas, minutos, segundos);
            tiempoParaMostrar = tiempoContador;
            lblTiempo.Text = tiempoParaMostrar.ToString(@"hh\:mm\:ss");
            btnIniciarParar.Text = "Iniciar";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Form2 editorTemporizador = new Form2();
            if (editorTemporizador.ShowDialog(this) == DialogResult.OK)
            {
                horas = (int)editorTemporizador.cbHoras.SelectedItem;
                minutos = (int)editorTemporizador.cbMinutos.SelectedItem;
                segundos = (int)editorTemporizador.cbSegundos.SelectedItem;
            }
            tiempoContador=new TimeSpan(horas, minutos, segundos);
            tiempoParaMostrar = tiempoContador;
            lblTiempo.Text = tiempoParaMostrar.ToString(@"hh\:mm\:ss");
            btnIniciarParar.Text = "Iniciar";
            timer1.Enabled = false;
        }
    }
}
