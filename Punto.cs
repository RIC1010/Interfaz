using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    //20191923-->Ricardo Sebastián Silva
    //20192037-->Juan Ignacio Ureta
    //20191669-->Eduardo Reyes
    //20193354-->Fernando Rodriguez
    class Punto
    {
        public string res = "";
        public double distancia;
        public double[] datos = new double[16];
        public Punto(double g, double edad, double alt, double peso, double fam, double fcac,
        double fcv, double nrod, double centre, double fuma, double agua, double moni,
        double facf, double cantElec, double alcohol, double trans)
        {
            datos[0] = g;
            datos[1] = edad;
            datos[2] = alt;
            datos[3] = peso;
            datos[4] = fam;
            datos[5] = fcac;
            datos[6] = fcv;
            datos[7] = nrod;
            datos[8] = centre;
            datos[9] = fuma;
            datos[10] = agua;
            datos[11] = moni;
            datos[12] = facf;
            datos[13] = cantElec;
            datos[14] = alcohol;
            datos[15] = trans;
            
        }
        
    }
}
