using Evaluacion1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var buque1 = new Buque("35899","Altamar","Chile",50);
            var buque2 = new Buque("35877", "La Esmeralda", "Chile", 40);
            var buque3 = new Buque("35866", "Huáscar", "Perú", 40);

            var container1 = new Container("1", "Marca", 2000, 20, false, 1200);
            var container2 = new Container("2", "Marcados", 8000, 40, true, 3500);
            var container3 = new Container("3", "Marcatres", 2000, 20, false, 150);
            var container4 = new Container("4", "Marcuatro", 8000, 40, false, 8000);

            buque1.SubirContainer(container1);
            buque1.SubirContainer(container2);
            buque2.SubirContainer(container3);
            buque3.SubirContainer(container4);

            buque1.ListarContainers();

            container3.ValorPagoInspeccion();

            Console.WriteLine("Costo container 1: $" + container1.CalcularGastosEnvio());
            Console.WriteLine("Costo container 2: $" + container2.CalcularGastosEnvio());
            Console.WriteLine("Costo container 3: $" + container3.CalcularGastosEnvio());
            Console.WriteLine("Costo container 4: $" + container4.CalcularGastosEnvio());

            container4.PuedeSubir(container4.CantidadMaxima,2000);

            container1.SacarPeso(200);

            Console.ReadKey();

        }
    }
}