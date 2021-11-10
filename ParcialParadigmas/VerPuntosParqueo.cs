using System;
using System.Windows.Forms;

namespace ParcialParadigmas
{
    public partial class VerPuntosParqueo : Form
    {
        Parqueadero elo = new Parqueadero();
        home conhome = new home();
        public VerPuntosParqueo()
        {
            InitializeComponent();
            
        }

        private void VerPuntosParqueo_Load(object sender, EventArgs e)
        {
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            home verinicio = new home();
            verinicio.Show();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
