using System.Runtime.Intrinsics.Arm;

namespace EjercicioIntegrador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("     Administrador de Instancias ");
            Console.WriteLine("========================================");


            Instancia proceso1 = new InstanciaProcesoDatos("Ec2", "v01.1", "aws-linux 2", " 000111222333", "44%%&&6677");
            Instancia proceso2 = new InstanciaProcesoDatos("Lambda", "v2.0", "Window server", "db://database/", "db://database");

            Instancia app1 = new InstanciaAplicacion("Web-Front-app", "v1.2", "Ubuntu", "C#.NET", "8.0", "Microsoft SQL server");
            Instancia app2 = new InstanciaAplicacion("Api-Backend", "v3.11", "linux mint", "Python", "4.5", "Postgres://api-db-host/");

            List<Instancia> instancias = new List<Instancia> { proceso1, proceso2, app1, app2 };            

            Console.WriteLine("******  Levantando las instancias  ******");
            Console.WriteLine("#############################################");

            foreach (var Instancia in instancias)
            {
                Instancia.Levantar();
            }
            Console.WriteLine("******  Bajando las instancias  ******");
            Console.WriteLine("#############################################");
            foreach (var Instancia in instancias)
            {
                Instancia.Bajar();
            }
            Console.WriteLine("****** Estado actual de las instancias ******");
            Console.WriteLine("#############################################");
            foreach (var Instancia in instancias)
            {
                Instancia.MostrarEstado();
            }
        }
    }
}
