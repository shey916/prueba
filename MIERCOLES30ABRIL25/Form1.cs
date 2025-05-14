using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MIERCOLES30ABRIL25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btncrearf_Click(object sender, EventArgs e)
        {
            // StreamWrite es la clase que representa a un fichero de texto en el que podemos escribir informacion
            // El fichero de texto lo creamos con el metodo(estatico) CreateText, que pertenece a la clase File
            // Para escribir en el fichero, empleamos Write y WriteLine
            // Close para cerrar el archivo, o podria quedar algun dato sin guardar
            StreamWriter fichero;
            fichero = File.CreateText("fichero1.txt");
            fichero.WriteLine("hola este es mi primer fichero");
            fichero.Write("Sheyla Moncada");
            fichero.Write("\r\n");
            fichero.WriteLine("Parte de la linea anterior");
            fichero.Close();
        }

        private void btncrearf2_Click(object sender, EventArgs e)
        {
            using (StreamWriter fichero = new StreamWriter("fichero1.txt"))
            {
                fichero.WriteLine("este codigo es mas compacto");
                fichero.WriteLine("shey");
                fichero.WriteLine("estefania");
            }
        }

        private void btnleer1_Click(object sender, EventArgs e)
        {
            StreamReader fichero;
            string linea;
            fichero = File.OpenText("fichero1.txt");
            linea=fichero.ReadLine();
            Console.WriteLine(linea);
            fichero.Close();
        }
        private void btnleer2_Click(object sender, EventArgs e)
        {
            using(StreamReader fichero=File.OpenText("fichero1.txt"))
            {
                string linea;
                linea=fichero.ReadLine();
                Console.WriteLine(linea);
                Console.WriteLine(fichero.ReadLine());
                Console.WriteLine(fichero.ReadLine());
            }
        }
        private void btnleer3_Click(object sender, EventArgs e) //boton leer final
        {
            StreamReader fichero;
            fichero = File.OpenText("fichero1.txt");
            while(!fichero.EndOfStream)
                Console.WriteLine(fichero.ReadLine());
            fichero.Close();
        }

        private void btnleer4_Click(object sender, EventArgs e)
        {
            StreamReader fichero;
            string linea;
            fichero = File.OpenText("fichero1.txt");
            do
            {
                linea = fichero.ReadLine();
                if (linea != null)
                    Console.WriteLine(linea);
            }
            while (linea != null);
            fichero.Close();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            StreamWriter fichero;
            fichero = File.CreateText("fichero2.txt");
            fichero.WriteLine("primera prueba");
            fichero.Close();

            fichero = File.AppendText("fichero2.txt");
            fichero.WriteLine("segunda prueba");
            fichero.Close();
        }
    }
}
