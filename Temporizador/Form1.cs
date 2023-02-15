using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temporizador
{
    public partial class Form1 : Form
    {

        public int horas;
        public int minutos;
        public int segundos;
        DateTime tiempoInicial;
        TimeSpan tiempoParaMostrar;
        TimeSpan tiempoContador = new TimeSpan();
        TimeSpan intervalo;
        private string sonidoSeleccionado;
        private string mensaje = "";
        public static Dictionary<string, SoundPlayer> sonidos = new Dictionary<string, SoundPlayer>();
        public Form3 dialogoFinalizacion = new Form3();
        private Form2 editorTemporizador = new Form2();


        public Form1()
        {
            InitializeComponent();
            //InitCustomFont();
            horas = 0;
            minutos = 4;
            segundos = 0;
            tiempoContador = new TimeSpan(horas, minutos, segundos);
            sonidos["Game over retro"] = new SoundPlayer(Properties.Resources.mixkit_arcade_retro_game_over_213);
            sonidos["Game over clásico"] = new SoundPlayer(Properties.Resources.mixkit_sad_game_over_trombone_471);
            sonidos["Aplauso"] = new SoundPlayer(Properties.Resources.mixkit_small_group_cheer_and_applause_518);
            sonidos["Alarma clásica"] = new SoundPlayer(Properties.Resources.mixkit_classic_alarm_995);
            
            lblTiempo.Text = tiempoContador.ToString(@"hh\:mm\:ss");
            sonidoSeleccionado = sonidos.Keys.First();
            
        }

        private void btnIniciarParar_Click(object sender, EventArgs e)
        {
            if (btnIniciarParar.Text == "Iniciar")
            {
                tiempoInicial = DateTime.Now;
                timer1.Enabled = true;
                btnIniciarParar.Text = "Pausar";
                btnIniciarParar.BackColor = Color.DarkRed;

            }
            else
            {
                tiempoContador = tiempoParaMostrar;
                timer1.Enabled = false;
                btnIniciarParar.Text = "Iniciar";
                btnIniciarParar.BackColor = Color.DarkGreen;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            intervalo = DateTime.Now - tiempoInicial;
            
            tiempoParaMostrar = tiempoContador.Subtract(intervalo);
            if (tiempoParaMostrar.CompareTo(TimeSpan.Zero) <= 0)
            {
                timer1.Enabled = false;
                dialogoFinalizacion.Sonido = sonidos[sonidoSeleccionado];
                dialogoFinalizacion.TextoTiempoFinalizado.Text = mensaje;
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
            btnIniciarParar.BackColor = Color.DarkGreen;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editorTemporizador.numericHoras.Value = horas;
            editorTemporizador.numericMinutos.Value = minutos;
            editorTemporizador.numericSegundos.Value = segundos;
            editorTemporizador.cbSonidos.DataSource = new List<string>(sonidos.Keys);
            editorTemporizador.cbSonidos.SelectedItem = sonidoSeleccionado;
            if (editorTemporizador.ShowDialog(this) == DialogResult.OK)
            {
                horas = (int)editorTemporizador.numericHoras.Value;
                minutos = (int)editorTemporizador.numericMinutos.Value;
                segundos = (int)editorTemporizador.numericSegundos.Value;
                sonidoSeleccionado = (string)editorTemporizador.cbSonidos.SelectedItem;
            }
            tiempoContador=new TimeSpan(horas, minutos, segundos);
            tiempoParaMostrar = tiempoContador;
            lblTiempo.Text = tiempoParaMostrar.ToString(@"hh\:mm\:ss");
            btnIniciarParar.Text = "Iniciar";
            timer1.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
