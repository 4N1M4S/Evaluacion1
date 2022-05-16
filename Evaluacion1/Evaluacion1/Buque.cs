using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion1
{
    internal class Buque
    {
        private int codigo;
        private string nombre;
        private string pais;
        private int cantidadContainers;
        private int cantidadContainersCargados;
        private int gastoTransporte;
        private List<Container> listaContainers;

        /// <summary>
        /// Constructor solo con código de la clase
        /// </summary>
        /// <param name="codigo"></param>
        public Buque(int codigo)
        {
            this.codigo = codigo;
        }

        /// <summary>
        /// Constructor completo de la clase
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="nombre"></param>
        /// <param name="pais"></param>
        /// <param name="cantidadContainers"></param>
        /// <param name="cantidadContainersCargados"></param>
        /// <param name="gastoTransporte"></param>
        /// <param name="listaContainers"> Lista de containers almacenados dentro de un buque </param>
        public Buque(int codigo, string nombre, string pais, int cantidadContainers, int cantidadContainersCargados, int gastoTransporte, List<Container> listaContainers) : this(codigo)
        {
            this.nombre = nombre;
            this.pais = pais;
            this.cantidadContainers = cantidadContainers;
            this.cantidadContainersCargados = cantidadContainersCargados;
            this.gastoTransporte = gastoTransporte;
            this.listaContainers = listaContainers;
        }
    }
}
