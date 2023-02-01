using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public Form2()
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
            cbMinutos.DataSource = valoresMinutos;
            cbSegundos.DataSource = valoresSegundos;

        }

        private void lblHoras_Click(object sender, EventArgs e)
        {

        }
    }
}
