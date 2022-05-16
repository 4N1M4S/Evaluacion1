using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion1
{
    internal class Container
    {
        private int codigo;
        private string marca;
        private int cantidadMaxima;
        private byte tamaño;
        private bool esRefrigerado;
        private int pesoActual;
        public Buque buque;

        /// <summary>
        /// Constructor solo con código
        /// </summary>
        /// <param name="codigo"> Código del container </param>
        public Container(int codigo)
        {
            this.codigo = codigo;
        }

        /// <summary>
        /// Constructor con parámetros privados de la clase
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="marca"></param>
        /// <param name="cantidadMaxima"></param>
        /// <param name="tamaño"></param>
        /// <param name="esRefrigerado"></param>
        /// <param name="pesoActual"></param>
        public Container(int codigo, string marca, int cantidadMaxima, byte tamaño, bool esRefrigerado, int pesoActual) : this(codigo)
        {
            this.marca = marca;
            this.cantidadMaxima = cantidadMaxima;
            this.tamaño = tamaño;
            this.esRefrigerado = esRefrigerado;
            this.pesoActual = pesoActual;
        }

        /// <summary>
        /// Constructor completo de la clase
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="marca"></param>
        /// <param name="cantidadMaxima"></param>
        /// <param name="tamaño"></param>
        /// <param name="esRefrigerado"></param>
        /// <param name="pesoActual"></param>
        /// <param name="buque"> Código del buque donde está el container </param>
        public Container(int codigo, string marca, int cantidadMaxima, byte tamaño, bool esRefrigerado, int pesoActual, Buque buque) : this(codigo, marca, cantidadMaxima, tamaño, esRefrigerado, pesoActual)
        {
            this.buque = buque;
        }
    }
}
