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
        
        
        public home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {
            
        }
        int i = 0;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Parqueadero generar = new Parqueadero();
            generar.GenerarParkingSpot();


            txtPlaca.Clear();
            txtMarca.Clear();
            txtIndetificacion.Clear();
            var t = cmbTipo.Text;
            var m = txtMarca.Text;
            var p = txtPlaca.Text;
            var i = txtIndetificacion.Text;
            var s = "";
            var ho = radHombre.Checked;
            var mu = radMujer.Checked;
            var a = "";
            var afi = cheAfiliado.Checked;
            if (afi)
            {
                a = "y que esta afiliado";

            }
            if (ho)
            {
                s= "masculino";

            }
            if (mu)
            {
                s = "femnino";

            }

            a+= "el " + t + " de marca " + m + "con placa " + p + "del propietario con cc= " + i + " de sexo " + s + a;
            
            
        }
    }

    public class Parqueadero
    {
        
        public int Capcidad { get; set; }
        public int Disponibles { get; set; }
        public int Ocupados{ get; set; }
    List<ParkingSpot> Espacios = new List<ParkingSpot>();
        

        public void GenerarParkingSpot()
        {
            for (int i = 0; i <= 9; i++)
            {
                Espacios.Add(new ParkingSpot());
            }
           
            Espacios[0].Disponible=true;
           //sirve para generar los Parking Spots del parqueadero
        }
        public void VerificarDisponibilidad() {
        
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
        


    }
    public class ParkingSpot
    {
        public bool Disponible { get; set; }
        public int Numerodeestacionamiento { get; set; }
        public string DatosVehiculoYconductor{ get; set; }

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
