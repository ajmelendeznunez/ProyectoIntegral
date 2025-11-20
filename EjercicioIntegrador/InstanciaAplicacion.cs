using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador
{
    internal class InstanciaAplicacion : Instancia
    {
        string lenguajeProgramacion;
        string versionLenguaje;
        string baseDatosURL;

        public string LenguajeProgramacion { get; set; }
        public string VersionLenguaje { get; set; }
        public string BaseDatosURL { get; set; }

        public InstanciaAplicacion() { }

        public InstanciaAplicacion(string nombre, string version, string sisOperativo, string lenguajeProgramacion, string versionlenguaje, string baseDatosURL) 
            : base(nombre, version, sisOperativo)
        {
            this.lenguajeProgramacion = lenguajeProgramacion;
            this.versionLenguaje = versionlenguaje;
            this.baseDatosURL = baseDatosURL;
        }
        public override void Levantar()
        {
            Console.WriteLine("Iniciando instancia de Aplicaciones:  " + nombre + " " + version + " " + sisOperativo);

            bool lenguajeInstalado = true;
            bool accesoBD = true;

            if (lenguajeInstalado && accesoBD)
            {
                Estado = estadoInstancia.Up;
                Console.WriteLine("La instancia se ha iniciado correctamente " + nombre + " " + version + " " + sisOperativo);
                Console.WriteLine("Se instalo corectamente el lenguaje de programacion " + lenguajeProgramacion + " version: " + versionLenguaje);
                Console.WriteLine("Se conecto correctamente en la base de datos " + baseDatosURL);
                Console.WriteLine("################################################");
            }
            else
            {
                Console.WriteLine("[ERRORRR] No se puede realizar el inicio de la instancia " + Nombre + " " + SisOperacitivo);
                Console.WriteLine("################################################");
            }
        }
    }
}
