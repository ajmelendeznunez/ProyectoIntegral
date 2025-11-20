using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador
{
    public enum estadoInstancia { Down, Up }
    internal abstract class Instancia
    {
        protected string nombre;
        protected string version;
        protected string sisOperativo;
        protected estadoInstancia estado;

        public string Nombre { get; set; }
        public string Version { get; set; }
        public string SisOperacitivo { get; set; }
        public estadoInstancia Estado { get; set; }

        public Instancia() { }
        protected Instancia(string nombre, string version, string sisOperativo)
        {
            this.nombre = nombre;
            this.version = version;
            this.sisOperativo = sisOperativo;
            estado = estadoInstancia.Down;
        }
        public abstract void Levantar();

        public virtual void Bajar() 
        {
            if (estado == estadoInstancia.Up)
            {
                estado = estadoInstancia.Down;
                Console.WriteLine("La intancia " + nombre + " " + version + " " + sisOperativo + " se bajo. Nuevo estado: " + Estado);
            }
            else
            {
                Console.WriteLine("La instancia " + nombre + " " + version + " " + sisOperativo + " ya estaba abajo. Estado actual: " + Estado);            
            }
        }
        public void MostrarEstado() 
        {
            Console.WriteLine("La instancia " + nombre + " " + sisOperativo + " su Estado: " + estado);

        }
        
    }
}
