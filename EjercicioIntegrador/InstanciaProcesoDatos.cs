using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador
{
    internal class InstanciaProcesoDatos : Instancia
    {
        string datosOrigen;
        string datosFin;

        public string DatosOrigen { get; set; }
        public string DatosFin { get; set; }

        public InstanciaProcesoDatos() { }

        public InstanciaProcesoDatos(string nombre, string version , string sisOperativo, string datosOrigen, string datosFin)
            : base(nombre, version, sisOperativo)
        {
            this.datosOrigen = datosOrigen;
            this.datosFin = datosFin; 
        }
        public override void Levantar()
        {
            Console.WriteLine("Iniciando instancia de Proceso de Datos:  " + nombre + " " + version + " " + sisOperativo);

            bool accesoOrigen = true;
            bool accesoFin = true;

            if (accesoOrigen == true && accesoFin == true)
            {
                Estado = estadoInstancia.Up;
                Console.WriteLine("Se inicio la instancia correctamente: " + nombre + " " + version + " " + sisOperativo + " correctamente");
                Console.WriteLine("acceso a datos Origen exitoso!");
                Console.WriteLine("acceso a datos Fin exitoso! ");
                Console.WriteLine("##############################################");
            }
            else 
            {
                Console.WriteLine("[ERRORRR] No se puede realizar el inicio de la instancia " + Nombre + " " + SisOperacitivo);
                Console.WriteLine("################################################");
            }

        }
    }
}
