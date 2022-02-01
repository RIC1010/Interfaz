using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    class GestorPuntos
    {
        Punto[] arr;
        //leemos el archivo
        public void read(string archivo)
        {
            Punto[] arrvar = new Punto[1999];
            TextReader Leer = new StreamReader(archivo);
            //realizamos la lectura solo de 1999 datos para realizar casos de prueba con los restantes 
            for (int j = 0; j < 1999; j++)
            {
                string variable = Leer.ReadLine();
                string[] datos = variable.Split(',');
                string[] antes = { datos[0], datos[4], datos[5], datos[8], datos[9], datos[11], datos[14], datos[15] };
                double[] despues = { 0, 0, 0, 0, 0, 0, 0, 0 };
                var validacion = new Dictionary<string, double>();
                validacion["yes"] = 1;
                validacion["no"] = 0;
                validacion["Sometimes"] = 1;
                validacion["Frequently"] = 2;
                validacion["Always"] = 3;
                validacion["Male"] = 1;
                validacion["Female"] = 0;
                validacion["Public_Transportation"] = 0;
                validacion["Automobile"] = 1;
                validacion["Walking"] = 2;
                validacion["Motorbike"] = 3;
                validacion["Bike"] = 4;
                for (int i = 0; i < antes.Length; i++)
                {
                    despues[i] = validacion[antes[i]];
                }
                //Creamos un "punto" por cada dato obtenido 
                Punto pun = new Punto(despues[0], Convert.ToDouble(datos[1]), Convert.ToDouble(datos[2]),
                Convert.ToDouble(datos[3]), despues[1], despues[2], Convert.ToDouble(datos[6]),
                Convert.ToDouble(datos[7]), despues[3], despues[4], Convert.ToDouble(datos[10]), despues[5],
                Convert.ToDouble(datos[12]), Convert.ToDouble(datos[13]), despues[6], despues[7]);
                pun.res = datos[16];
                //agregamos el punto leído a un arreglo temporal
                arrvar[j] = pun;
            }
            //asignamos el arreglo temporal de "puntos" al parámtero arreglo de tipo punto que tiene la clase
            arr = arrvar;
        }
        static double lpow(double x, int y)
        {
            double res = 1;
            while (y > 0)
            {
                if ((y & 1) == 1)
                {
                    res *= x;
                }
                y = y >> 1;
                x *= x;
            }
            return res;
        }
        //algoritmo KNN implementado como método de la clase GestorPuntos
        public string KNN(Punto vari, int k)
        {
            for (int i = 0; i < 1999; i++)
            {
                double suma = 0;
                for (int j = 0; j < 16; j++)
                {
                    suma += lpow(arr[i].datos[j] - vari.datos[j], 2);
                }
                arr[i].distancia = Math.Sqrt(suma);
            }
            //ordenamos el arreglo de puntos de acuerdo a la distancia que tienen al nuevo punto 
            IEnumerable<Punto> aux = arr.OrderBy(auxi1 => auxi1.distancia);
            var tipos = new Dictionary<string, int>();
            tipos["Insufficient_Weight"] = 0;
            tipos["Normal_Weight"] = 0;
            tipos["Overweight_Level_I"] = 0;
            tipos["Overweight_Level_II"] = 0;
            tipos["Obesity_Type_I"] = 0;
            tipos["Obesity_Type_II"] = 0;
            tipos["Obesity_Type_III"] = 0;
            int maxi = 0;
            foreach (Punto p in aux)
            {
                //hasta recorrer los "k" vecinos más cercanos
                if (maxi == k)
                {
                    break;
                }
                tipos[p.res]++;
                maxi++;
            }
            int mayor = 0;
            string aretornar = "";
            foreach (KeyValuePair<string, int> entry in tipos)
            {
                int varia = entry.Value;
                if (varia > mayor)
                {
                    mayor = varia;
                    aretornar = entry.Key;
                }
            }
            return aretornar;
        }
    }
}
