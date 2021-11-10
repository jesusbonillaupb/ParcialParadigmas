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
        Vehicle coneccionvehiculo = new Vehicle();
        driver coneccionconductor = new driver();
        ParkingSpot coneccionParking = new ParkingSpot();
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
        public string DatosVehiculo;
        public string sa;
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
                var h = DateTime.Now.ToString("h:m tt");
                var hx = DateTime.Now.TimeOfDay;
                var fecha = DateTime.Now.ToString( "d/M ");

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
                //atributos vehiculo
                coneccionvehiculo.Tipo = t;
                coneccionvehiculo.Marca = m;
                coneccionvehiculo.Placa = p;
                coneccionvehiculo.HoraEntrada = h;
                //atributos conductor
                coneccionconductor.Indentificacion = di;
                coneccionconductor.Sexo = s;

                DatosVehiculo = t + " de marca " + m + " con placa " + p;
                string DatosConductor = " conductor con cc= " + di + " de sexo " + s + a;
                string DatosTiempo = "ingreso en " + fecha + " a las "+h;
                string textosalida = DatosVehiculo + " y " + DatosConductor+ DatosTiempo+"\n";
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
                            generar.Espacios[0].DatosVehiculoYConductor = textosalida;
                             sa=generar.Espacios[7].DatosVehiculoYConductor = textosalida;
                            
                        }
                        if (generar.Espacios[1].Disponible == false)
                        {
                            btnE2.BackColor = Color.Red;
                            generar.Espacios[1].DatosVehiculoYConductor = textosalida;
                             sa = generar.Espacios[7].DatosVehiculoYConductor = textosalida;
                        }
                        if (generar.Espacios[2].Disponible == false)
                        {
                            btnE3.BackColor = Color.Red;
                            generar.Espacios[2].DatosVehiculoYConductor = textosalida;
                            sa = generar.Espacios[7].DatosVehiculoYConductor = textosalida;
                        }
                        if (generar.Espacios[3].Disponible == false)
                        {
                            btnE4.BackColor = Color.Red;
                            generar.Espacios[3].DatosVehiculoYConductor = textosalida;
                             sa = generar.Espacios[7].DatosVehiculoYConductor = textosalida;
                        }
                        if (generar.Espacios[4].Disponible == false)
                        {
                            btnE5.BackColor = Color.Red;
                            generar.Espacios[4].DatosVehiculoYConductor = textosalida;
                             sa = generar.Espacios[7].DatosVehiculoYConductor = textosalida;
                        }
                        if (generar.Espacios[5].Disponible == false)
                        {
                            btnE6.BackColor = Color.Red;
                            generar.Espacios[5].DatosVehiculoYConductor = textosalida;
                            sa = generar.Espacios[7].DatosVehiculoYConductor = textosalida;
                        }
                        if (generar.Espacios[6].Disponible == false)
                        {
                            btnE7.BackColor = Color.Red;
                            generar.Espacios[6].DatosVehiculoYConductor = textosalida;
                             sa = generar.Espacios[7].DatosVehiculoYConductor = textosalida;
                        }
                        if (generar.Espacios[7].Disponible == false)
                        {
                            btnE8.BackColor = Color.Red;
                             sa=generar.Espacios[7].DatosVehiculoYConductor = textosalida;
                        }
                        if (generar.Espacios[8].Disponible == false)
                        {
                            btnE9.BackColor = Color.Red;
                            sa = generar.Espacios[8].DatosVehiculoYConductor = textosalida;
                        }
                        if (generar.Espacios[9].Disponible == false)
                        {
                            btnE10.BackColor = Color.Red;
                            generar.Espacios[8].DatosVehiculoYConductor = textosalida;
                            sa = generar.Espacios[7].DatosVehiculoYConductor = textosalida;
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
            var horafinal= DateTime.Now;
        }

        private void btnE2_Click_1(object sender, EventArgs e)
        {
            generar.Espacios[1].Disponible = true;
            generar.VerificarDisponibilidad();
            
            btnE2.BackColor = Color.Green;
            lblNoHayEspacio.Hide();
            var horafinal = DateTime.Now;
            
        }

        private void btnE3_Click_1(object sender, EventArgs e)
        {
            generar.Espacios[2].Disponible = true;
            generar.VerificarDisponibilidad();
            
            btnE3.BackColor = Color.Green;
            lblNoHayEspacio.Hide();
            var horafinal = DateTime.Now;
        }

        private void btnE4_Click(object sender, EventArgs e)
        {
            generar.Espacios[3].Disponible = true;
            generar.VerificarDisponibilidad();
            var horafinal = DateTime.Now;
            btnE4.BackColor = Color.Green;
            lblNoHayEspacio.Hide();
        }

        private void btnE5_Click_1(object sender, EventArgs e)
        {
            generar.Espacios[4].Disponible = true;
            var horafinal = DateTime.Now;
            btnE5.BackColor = Color.Green;
            generar.Espacios[9].Disponible = true;
            lblNoHayEspacio.Hide();
        }

        private void btnE6_Click_1(object sender, EventArgs e)
        {
            generar.Espacios[5].Disponible = true;
            
            btnE6.BackColor = Color.Green;
            generar.Espacios[9].Disponible = true;
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

        private void lblRetirado_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarE_Click(object sender, EventArgs e)
        {
            VerPuntosParqueo verpu = new VerPuntosParqueo();
            verpu.Show();
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
            
            for(int i = 0; i <= 9; i+=1)
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

        
       
    }
    public class Vehicle
    {
        public string Tipo { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string HoraEntrada { get; set; }
        public string HoraSalida { get; set; }
        
    }
    public class driver
    {
        public string Indentificacion { get; set; }
        public string Sexo { get; set; }
        public bool Afiliado { get; set; }


    }
    //nota:depronto se pueda crear una clase tarifa la cual tenga atributos la hora de entrada, la hora de salida, el precio por minuto y el incremento
    //posibles metodos: calcular tarifa 
}
