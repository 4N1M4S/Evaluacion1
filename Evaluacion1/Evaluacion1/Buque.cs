namespace Evaluacion1
{
    internal class Buque
    {
        private string codigo;
        private string nombre;
        private string pais;
        private int cantidadContainers;
        private int cantidadContainersCargados;
        private int gastoTransporte;
        private List<Container> listaContainers = new List<Container>();

        /// <summary>
        /// Getters y setters de la clase
        /// </summary>
        public string Codigo { get { return codigo; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Pais { get { return pais; } set { pais = value; } }
        public int CantidadContainers { get { return cantidadContainers; } set { cantidadContainers = value; } }
        public int CantidadContainersCargados { get { return cantidadContainersCargados; } set { cantidadContainersCargados = value; } }
        public int GastoTransporte { get { return gastoTransporte; } set { gastoTransporte = value; } }
        public List<Container> Containers { get { return listaContainers; } set { listaContainers = value; } }

        /// <summary>
        /// Constructor solo con código de la clase
        /// </summary>
        /// <param name="codigo"></param>
        public Buque(string codigo)
        {
            if (codigo.Length>=5)
            {
                this.codigo = codigo;
            }
            else
            {
                Console.WriteLine("El código es demasiado corto");
            }
        }

        /// <summary>
        /// Constructor con datos básicos de buque
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="nombre"></param>
        /// <param name="pais"></param>
        /// <param name="cantidadContainers"></param>
        public Buque(string codigo, string nombre, string pais, int cantidadContainers) : this(codigo)
        {
            if (codigo.Length >= 5)
            {
                this.codigo = codigo;
                this.nombre = nombre;
                this.pais = pais;
                this.cantidadContainers = cantidadContainers;
            }
            else
            {
                Console.WriteLine("El código es demasiado corto");
            }
            
        }


        /// <summary>
        /// Método para subir un container si es que posee
        /// la capacidad para ello siempre y cuando el método
        /// PuedeSubir() de Container devuelva true
        /// </summary>
        /// <param name="container"> Objeto Container que será ingresado al buque </param>
        public bool SubirContainer(Container container)
        {
            bool esPosible = false;

            int tamañoContainer = 0;

            if (container.Tamaño == 20)
            {
                tamañoContainer = 1;
            }
            else if (container.Tamaño == 40)
            {
                tamañoContainer = 2;
            }

            int espacioFinal = cantidadContainersCargados + tamañoContainer;

            if (espacioFinal > cantidadContainers)
            {
                Console.WriteLine("El buque no tiene la capacidad disponible para almacenar el container que desea ingresar");
            }
            else
            {
                esPosible = true;
                cantidadContainersCargados = espacioFinal;
                container.Buque = new Buque(codigo, nombre, pais, cantidadContainers);
                listaContainers.Add(container);
                Console.WriteLine("El container ha sido agregado a la carga del buque");
            }

            

            return esPosible;   

        }

        public void ListarContainers()
        {
            foreach(Container container in listaContainers)
            {
                string str = container.ToString("G");
                Console.WriteLine(str);
            }
            
        }

    }
}
