﻿using System;
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
        public TimeSpan tiempoParaMostrar;
        public TimeSpan tiempoContador = new TimeSpan();
        TimeSpan intervalo;
        private string sonidoSeleccionado;
        public static Dictionary<string, SoundPlayer> sonidos = new Dictionary<string, SoundPlayer>();
        List<string> nombresSonidos;
        public Form3 dialogoFinalizacion = new Form3();
        private Form2 editorTemporizador = new Form2();
        bool bucleSonido = false;
        public int enCero; //0: Parar; 1: Reiniciar; 2: Cronómetro;
        public bool tiempoFinalizado = false;
        public static bool cuenta = true;

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font fuenteDigital;


        public Form1()
        {
            InitializeComponent();

            // Inicializar valores por defecto
            horas = 0;
            minutos = 0;
            segundos = 3;
            tiempoContador = new TimeSpan(horas, minutos, segundos);

            // Inicializar sonidos y sonido por defecto
            sonidos["Game over retro"] = new SoundPlayer(Properties.Resources.mixkit_arcade_retro_game_over_213);
            sonidos["Game over clásico"] = new SoundPlayer(Properties.Resources.mixkit_sad_game_over_trombone_471);
            sonidos["Aplauso"] = new SoundPlayer(Properties.Resources.mixkit_small_group_cheer_and_applause_518);
            sonidos["Alarma clásica"] = new SoundPlayer(Properties.Resources.mixkit_classic_alarm_995);
            nombresSonidos = new List<string>(sonidos.Keys);
            sonidoSeleccionado = sonidos.Keys.First();
            dialogoFinalizacion.Sonido = sonidos.Values.First();

            // Inicializar fuente personalizada y bloques de texto
            byte[] fontData = Properties.Resources.digital_7_mono_;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.digital_7_mono_.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.digital_7_mono_.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            fuenteDigital = new Font(fonts.Families[0], 60.0F);
            lblTiempo.Font = fuenteDigital;
            lblCrono.Font = fuenteDigital;
            lblCrono.Text = "";
            MostrarTiempo(tiempoContador);
            enCero = 0;
            
        }
        /**
         * Convierte un valor de intervalo de tiempo en una cadena legible y la asigna como texto a la label correspondiente.
         */
        public void MostrarTiempo(TimeSpan tiempo)
        {
            if (tiempo.Days > 0)
            {
                lblTiempo.Text = tiempo.ToString("%d") + " días " + tiempo.ToString(@"hh\:mm\:ss"); 
            }
            else if(tiempo.Hours > 0)
            {
                lblTiempo.Text = tiempo.ToString(@"hh\:mm\:ss");
            }
            else
            {
                lblTiempo.Text = tiempo.ToString(@"mm\:ss");
            }
        }

        private void btnIniciarParar_Click(object sender, EventArgs e)
        {
            if (btnIniciarParar.Text == "Iniciar")
            {
                IniciarCrono();

            }
            else
            {
                PausarCrono();
            }
        }

        /**
         * Detiene el temporizador y habilita el botón correspondiente para reanudarlo.
         */
        private void PausarCrono()
        {
            tiempoContador = tiempoParaMostrar;
            timer1.Enabled = false;
            btnIniciarParar.Text = "Iniciar";
            btnIniciarParar.BackColor = Color.DarkGreen;
        }

        /**
         * Inicia o reanuda el temporizador y habilita el botón correspondiente para pausarlo
         */
        private void IniciarCrono()
        {
            tiempoInicial = DateTime.Now;
            timer1.Enabled = true;
            btnIniciarParar.Text = "Pausar";
            btnIniciarParar.BackColor = Color.DarkRed;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            intervalo = DateTime.Now - tiempoInicial; // Calculamos el tiempo transcurrido desde que se inició/reanudó el contador
            
            tiempoParaMostrar = tiempoContador.Subtract(intervalo); //Calculamos el tiempo que debemos mostrar en base al tiempo transcurrido
            if (tiempoParaMostrar.CompareTo(TimeSpan.Zero) <= 0 && !tiempoFinalizado)// Si el tiempo que debemos mostrar es cero o menos hemos terminado el temporizador
            {
                tiempoFinalizado = true; // Damos por finalizado el tiempo para no volver a mostrar diálogos o reproducir alarmas
                if (dialogoFinalizacion.Visible)
                {
                    dialogoFinalizacion.Visible = false;
                }
                dialogoFinalizacion.Show(this); // Mostramos el diálogo para continuar o reiniciar el temporizador
                switch (enCero)
                {

                    case 0: // Al llegar a cero paramos el temporizador
                        timer1.Enabled = false;
                        
                        break;

                    case 1: // Al llegar a cero reiniciamos el temporizador
                        ReiniciarTemporizador();
                        break;

                    case 2: // Al llegar a cero continuamos contando el tiempo como cronómetro
                        lblCrono.Text = "+";
                        
                        break;

                    default:
                        break;
                }
                
            }
                
            MostrarTiempo(tiempoParaMostrar);

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            ReiniciarTemporizador();
        }

        /**
         * Reestablece los valores del temporizador tal y como fueron determinados y pone el temporizador en marcha
         */
        public void ReiniciarTemporizador()
        {
            tiempoFinalizado = false;
            tiempoContador = new TimeSpan(horas, minutos, segundos);
            tiempoParaMostrar = tiempoContador;
            MostrarTiempo(tiempoParaMostrar);
            btnIniciarParar.Text = "Iniciar";
            btnIniciarParar.BackColor = Color.DarkGreen;
            lblCrono.Text = "";
            IniciarCrono();
        }

        /**
         * Abre el formulario de edición del temporizador
         */
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Inicializa los valores para los controles del editor
            editorTemporizador.numericHoras.Value = horas;
            editorTemporizador.numericMinutos.Value = minutos;
            editorTemporizador.numericSegundos.Value = segundos;
            editorTemporizador.tbMensaje.Text = lblMensaje.Text;
            editorTemporizador.cbSonidos.DataSource = nombresSonidos;
            editorTemporizador.cbSonidos.SelectedItem = sonidoSeleccionado;
            editorTemporizador.checkBox1.Checked = bucleSonido;
            editorTemporizador.cbCero.SelectedIndex = enCero;

            if (editorTemporizador.ShowDialog(this) == DialogResult.OK) // Pulsando Aceptar recogemos los valores y ponemos en marcha
            {
                // Valores del temporizador
                horas = (int)editorTemporizador.numericHoras.Value;
                minutos = (int)editorTemporizador.numericMinutos.Value;
                segundos = (int)editorTemporizador.numericSegundos.Value;
                tiempoContador=new TimeSpan(horas, minutos, segundos);
                tiempoParaMostrar = tiempoContador;
                lblTiempo.Text = tiempoParaMostrar.ToString(@"hh\:mm\:ss");

                // Sonido de alarma
                sonidoSeleccionado = (string)editorTemporizador.cbSonidos.SelectedItem;
                bucleSonido = (bool)editorTemporizador.checkBox1.Checked;
                dialogoFinalizacion.Sonido = sonidos[(string)editorTemporizador.cbSonidos.SelectedItem];
                dialogoFinalizacion.bucleSonido = editorTemporizador.checkBox1.Checked;

                // Comportamiento al llegar a cero
                enCero = (int)editorTemporizador.cbCero.SelectedIndex;

                // Mensaje de alarma
                dialogoFinalizacion.TextoTiempoFinalizado.Text = editorTemporizador.tbMensaje.Text;
                lblMensaje.Text = editorTemporizador.tbMensaje.Text;

                tiempoFinalizado = false;
                IniciarCrono();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
