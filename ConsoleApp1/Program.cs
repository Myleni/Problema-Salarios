using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    { 

        static void Main(string[] args)
        {
            string[] Empleados = new string[4];
            Empleados[0] = "NNYN";
            Empleados[1] = "NNYN";
            Empleados[2] = "NNNN";
            Empleados[3] = "NYYN";


            Console.WriteLine(Evaluar(Empleados));
        }

        public static int Evaluar(string[] Empleados)
        {         
            int Total = 0;

            for (int i = 0; i < Empleados.Length; i++)
            {
                Total += Salario(i, Empleados);
            }
            return Total;
        }

        public static int Salario(int i, string[] Empleados)
        {
            int _salario=0;
            bool tiene = false;
            for (int j = 0; j < Empleados[i].Length; j++)
            {
                if (i != j)
                {
                    if (Empleados[i][j] == 'Y') { _salario +=  Salario(j, Empleados); tiene = true; }
                }
                
            }
            if (!tiene) return 1;
            else return _salario;
        }
    }
}
