using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialParadigmas
{
    public partial class home : Form
    {
        Parqueadero generar = new Parqueadero();

        public home()
        {
            InitializeComponent();
            
            generar.GenerarParkingSpot();
        }
        
        private void home_Load(object sender, EventArgs e)
        {
            
        }
        
        private void btnRotarIzquierda_Click(object sender, EventArgs e)
        {
            var btnX = btnE1.Location.X;
            var btnY= btnE1.Location.Y;

            this.btnE1.Location = new Point(btnE2.Location.X, btnE2.Location.Y);
                this.btnE2.Location = new Point(btnE3.Location.X, btnE3.Location.Y);
                this.btnE3.Location = new Point(btnE4.Location.X, btnE4.Location.Y);
                this.btnE4.Location = new Point(btnE5.Location.X, btnE5.Location.Y);
                this.btnE5.Location = new Point(btnE6.Location.X, btnE6.Location.Y);
                this.btnE6.Location = new Point(btnE7.Location.X, btnE7.Location.Y);
                this.btnE7.Location = new Point(btnE8.Location.X, btnE8.Location.Y);
                this.btnE8.Location = new Point(btnE9.Location.X, btnE9.Location.Y);
                this.btnE9.Location = new Point(btnE10.Location.X, btnE10.Location.Y);
                this.btnE10.Location = new Point(btnX, btnY);

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtIndetificacion.Clear();
        }

        public void btnAgregar_Click(object sender, EventArgs e)
        {
            if (generar.VerificarDisponibilidad() == false) {
                var t = cmbTipo.Text;
                var m = txtMarca.Text;
                var p = txtPlaca.Text;
                var di = txtIndetificacion.Text;
                var s = "";
                var ho = radHombre.Checked;
                var mu = radMujer.Checked;
                var a = "";
                var afi = cheAfiliado.Checked;
                if (afi)
                {
                    a = " y que esta afiliado";

                }
                if (ho)
                {
                    s = "masculino";

                }
                if (mu)
                {
                    s = "femnino";

                }
                string DatosVehiculo = t + " de marca " + m + " con placa " + p;
                string DatosConductor= " conductor con cc= " + di + " de sexo " + s + a;
                string textosalida = DatosVehiculo + " y " + DatosConductor+ "\n";
                rtbInfo.Text += textosalida;

                //if(espacios[1].disponibilidad=false{btnE1.color red}

                txtPlaca.Clear();
                txtMarca.Clear();
                txtIndetificacion.Clear();
                bool espacioLleno = false;
                while (espacioLleno == false)
                {
                    foreach (ParkingSpot x in generar.Espacios)
                    {
                        if (x.Disponible == true && espacioLleno == false)
                        {
                            x.Numerodeestacionamiento = generar.Espacios.IndexOf(x);
                            x.DatosVehiculoYConductor = textosalida;
                            x.Disponible = false;
                            espacioLleno = true;
                            rtbInfo.Text += "ubicado en el estacionamiento  numero " + (generar.Espacios.IndexOf(x)+1)+ "\n";
                        }
                        if (generar.Espacios[0].Disponible == false){ 
                            btnE1.BackColor = Color.Red; 
                        }
                        if (generar.Espacios[1].Disponible == false)
                        {
                            btnE2.BackColor = Color.Red;
                        }
                        if (generar.Espacios[2].Disponible == false)
                        {
                            btnE3.BackColor = Color.Red;
                        }
                        if (generar.Espacios[3].Disponible == false)
                        {
                            btnE4.BackColor = Color.Red;
                        }
                        if (generar.Espacios[4].Disponible == false)
                        {
                            btnE5.BackColor = Color.Red;
                        }
                        if (generar.Espacios[5].Disponible == false)
                        {
                            btnE6.BackColor = Color.Red;
                        }
                        if (generar.Espacios[6].Disponible == false)
                        {
                            btnE7.BackColor = Color.Red;
                        }
                        if (generar.Espacios[7].Disponible == false)
                        {
                            btnE8.BackColor = Color.Red;
                        }
                        if (generar.Espacios[8].Disponible == false)
                        {
                            btnE9.BackColor = Color.Red;
                        }
                        if (generar.Espacios[9].Disponible == false)
                        {
                            btnE10.BackColor = Color.Red;
                        }
                    }
                    
                }
            }
            else
            {
                lblNoHayEspacio.Show();
            }
            
            
        }

        private void btnE1_Click(object sender, EventArgs e)
        {
            generar.Espacios[0].Disponible = true;
            generar.VerificarDisponibilidad();
            btnE1.BackColor = Color.Green;
            lblNoHayEspacio.Hide();
            
        }

        private void btnE2_Click_1(object sender, EventArgs e)
        {
            generar.Espacios[1].Disponible = true;
            generar.VerificarDisponibilidad();
            btnE2.BackColor = Color.Green;
            lblNoHayEspacio.Hide();
        }

        private void btnE3_Click_1(object sender, EventArgs e)
        {
            generar.Espacios[2].Disponible = true;
            generar.VerificarDisponibilidad();
            btnE3.BackColor = Color.Green;
            lblNoHayEspacio.Hide();
        }

        private void btnE4_Click(object sender, EventArgs e)
        {
            generar.Espacios[3].Disponible = true;
            generar.VerificarDisponibilidad();
            btnE4.BackColor = Color.Green;
            lblNoHayEspacio.Hide();
        }

        private void btnE5_Click_1(object sender, EventArgs e)
        {
            generar.Espacios[4].Disponible = true;
            generar.VerificarDisponibilidad();
            btnE5.BackColor = Color.Green;
            lblNoHayEspacio.Hide();
        }

        private void btnE6_Click_1(object sender, EventArgs e)
        {
            generar.Espacios[5].Disponible = true;
            generar.VerificarDisponibilidad();
            btnE6.BackColor = Color.Green;
            lblNoHayEspacio.Hide();

        }

        private void btnE7_Click_1(object sender, EventArgs e)
        {
            generar.Espacios[6].Disponible = true;
            generar.VerificarDisponibilidad();
            btnE7.BackColor = Color.Green;
            lblNoHayEspacio.Hide();

        }

        private void btnE8_Click_1(object sender, EventArgs e)
        {
            generar.Espacios[7].Disponible = true;
            generar.VerificarDisponibilidad();
            btnE8.BackColor = Color.Green;
            lblNoHayEspacio.Hide();
        }

        private void btnE9_Click_1(object sender, EventArgs e)
        {
            generar.Espacios[8].Disponible = true;
            generar.VerificarDisponibilidad();
            btnE9.BackColor = Color.Green;
            lblNoHayEspacio.Hide();
        }

        private void btnE10_Click_1(object sender, EventArgs e)
        {
            generar.Espacios[9].Disponible = true;
            generar.VerificarDisponibilidad();
            btnE10.BackColor = Color.Green;
            lblNoHayEspacio.Hide();
        }
    }

    public class Parqueadero
    {
        
        public Parqueadero()
        {
            GenerarParkingSpot();
        }
        public int Capcidad { get; set; }
        public int Disponibles { get; set; }
        public int Ocupados{ get; set; }
        public List<ParkingSpot> Espacios = new List<ParkingSpot>();
        

        public void GenerarParkingSpot()
        {
            for (int i = 0; i <= 9; i+=1)
            {
                Espacios.Add(new ParkingSpot());
            }
           
              //sirve para generar los Parking Spots del parqueadero
        }
        
        public bool VerificarDisponibilidad() {
            bool nohaydisponibilidad=false;
            for (int i = 0; i <= 9; i+=1)
            {
                if (Espacios[i].Disponible == true)
                {
                    nohaydisponibilidad = false;
                }
                else //i==9 && Espacios[i].Disponible==false
                {
                    nohaydisponibilidad = true;
                }
                
            }
            return nohaydisponibilidad;
           
            //sirvira para verificar la disponibilidad de un espacio
            //ej: if espacio1 or espacio2 or espacio3 ... disponibilidad= true, seguir con el metodo AsignarParkingSpot()
            //ej: if espacio1 or espacio2 or espacio3 ... disponibilidad= false envar mensaje "no hay espacios disponibles"

        }
        public void AsignarParkingSpot()
        {
            
            //sirvira para asignar un carro a un determinado espacio disponible
            //como se dijo en el pdf se a se asigna el punto de parqueo más cercano en la banda que este vacio 
            //ej: if espacio1.Disponible= true, asignar carro a espacio1
            //luego se ingresara a ese veiculo

        }
        public void DenegarPorFaltaDeEspacio()
        {
            //sirvira para asignar un carro a un determinado espacio disponible
            //como se dijo en el pdf se a se asigna el punto de parqueo más cercano en la banda que este vacio 
            //ej: if espacio1.Disponible= true, asignar carro a espacio1
            //luego se ingresara a ese veiculo

        }


    }
    public class ParkingSpot
    {
        public ParkingSpot()
        {
            this.Disponible=true;
        }

        public bool Disponible { get; set; }
        public int Numerodeestacionamiento { get; set; }
        public string DatosVehiculoYConductor{ get; set; }

        public void IngresarVehiculo()
        {
            
            
            //sirvira para ingresar el vehiculo a un determinado estacionamiento y que el espacio de esta se marque en ocupado
        }
        public void RetirarrVehiculo()
        {
            //sirvira para ingresar el vehiculo a un determinado estacionamiento y que el espacio de esta se marque en libre
        }
    }
    public class Vehicle
    {
        string Tipo;
        string Placa;
        string Marca;
        string HoraEntrada;
        string HoraSalida;
        
    }
    public class driver
    {
        int Indentificacion;
        string Sexo;
        bool Afiliado;
       
        
    }
    //nota:depronto se pueda crear una clase tarifa la cual tenga atributos la hora de entrada, la hora de salida, el precio por minuto y el incremento
    //posibles metodos: calcular tarifa 
}
