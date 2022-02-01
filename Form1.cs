using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    //20191923-->Ricardo Sebastián Silva
    //20192037-->Juan Ignacio Ureta
    //20191669-->Eduardo Reyes
    //20193354-->Fernando Rodriguez
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            //instancia para medir tiempor
            Stopwatch CountTime = new Stopwatch();
            CountTime.Start();//inicia el tiempo
            var tipos = new Dictionary<string, double>();
            //asignamos valores numéricos a los datos que no lo son
            tipos["Sí"] = 1;
            tipos["No"] = 0;
            tipos["Algunas veces"] = 1;
            tipos["Frecuentemente"] = 2;
            tipos["Siempre"] = 3;
            tipos["Masculino"] = 1;
            tipos["Femenino"] = 0;
            tipos["Transporte público"] = 0;
            tipos["Auto"] = 1;
            tipos["Caminando"] = 2;
            tipos["Motocicleta"] = 3;
            tipos["Bicicleta"] = 4;
            string[] data1 = {res1.Text, res5.Text, 
            res6.Text, res9.Text, res10.Text, res12.Text,res15.Text, res16.Text };
            double[] data = new double[8];
            for (int i = 0; i < 8; i++)
            {
                data[i] = tipos[data1[i]];
            }
            //creamos la persona de acuerdo a los datos obtenidos en el formulario
            Punto punto = new Punto(data[0],Convert.ToDouble(res2.Text), Convert.ToDouble(res3.Text), 
            Convert.ToDouble(res4.Text), data[1], data[2],Convert.ToDouble(res7.Text), 
            Convert.ToDouble(res8.Text), data[3], data[4], 
            Convert.ToDouble(res11.Text), data[5], 
            Convert.ToDouble(res13.Text), Convert.ToDouble(res14.Text), data[6], data[7]);
            
            GestorPuntos datos = new GestorPuntos();
            //leemos los datos 
            datos.read("TuArchivoDatos.txt");
            //declaramos un k
            int k = 3;
            //realizamos el knn que dará como resultado el tipo de obesidad
            respuesta.Text = datos.KNN(punto, k);
            ////////////////////////////////////
            CountTime.Stop();//termina el tiempo
            //análisis para comparativa
            Console.WriteLine($"Tiempo: {CountTime.Elapsed.TotalSeconds} s");
            Console.WriteLine($"Precision: {(1.0 / Stopwatch.Frequency).ToString("E")} segundos");
            if (Stopwatch.IsHighResolution)
                Console.WriteLine("Alta precisión");
            else
                Console.WriteLine("Baja precisión");
            FileInfo fi = new FileInfo(Assembly.GetEntryAssembly().Location);
            Console.WriteLine(fi.Length);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonRes_MouseHover(object sender, EventArgs e)
        {
            buttonRes.BackColor= ColorTranslator.FromHtml("#C6E6D3");
        }

        private void buttonRes_MouseLeave(object sender, EventArgs e)
        {
            buttonRes.BackColor = ColorTranslator.FromHtml("#deefdd");
        }
    }
}
