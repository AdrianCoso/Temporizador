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
        int[] valoresHoras = new int[24];
        
     
        int[] valoresMinutos = new int[60];
        int[] valoresSegundos = new int[60];
        private string[] valoresSonidos = new string[] { "Retro game over", "Classic game over", "Aplauso", "Alarma clásica"};
        

        public Form2(int horas, int minutos, int segundos, Dictionary<string, SoundPlayer> sonidos)
        {
            InitializeComponent();
            for (int i = 0; i < valoresHoras.Length; i++)
            {
                valoresHoras[i] = i;
            }
            for (int i = 0; i < valoresMinutos.Length; i++)
            {
                valoresMinutos[i] = i;
                valoresSegundos[i] = i;
            } 
            cbHoras.DataSource = valoresHoras;
            cbHoras.SelectedItem = horas;
            cbMinutos.DataSource = valoresMinutos;
            cbMinutos.SelectedItem = minutos;
            cbSegundos.DataSource = valoresSegundos;
            cbSegundos.SelectedItem = segundos;
            cbSonidos.DataSource = new List<string>(sonidos.Keys);
            
        }

        public ComboBox getComboHoras()
        {
            return cbHoras;
        }
        public ComboBox getComboMinutos()
        {
            return cbMinutos;
        }
        public ComboBox getComboSegundos()
        {
            return cbSegundos;
        }
        public ComboBox getComboSonidos()
        {
            return cbSonidos;
        }
    }
}
