using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectco_01_s2
{
    internal class Program
    {
        class Persona
        {
            private int codigo;

            public int Codigo
            {
                get { return codigo; }
                set { if (value > 0)
                    { codigo = value; }
                }
            }

            private string nombre;

            public string Nombre
            {
                get { return nombre; }
                set { if (!string.IsNullOrEmpty(value))
                    { nombre = value; }
                }
            }

            private string numeroTelefono;

            public string NumeroTelefono
            {
                get { return numeroTelefono; }
                set { if (!string.IsNullOrEmpty(value))
                    { numeroTelefono = value; }
                }
            }

            public virtual void MostrarInformacion()
            {
                Console.WriteLine("Código: " + Codigo);
                Console.WriteLine("Nombre: " + Nombre);
                Console.WriteLine("Número de Teléfono: " + NumeroTelefono);
            }

            public Persona(int codigo, string nombre, string numeroTelefono)
            {
                Codigo = codigo;
                Nombre = nombre;
                NumeroTelefono = numeroTelefono;
            }

        }

        class Cliente : Persona
        {
            private string correoElectronico;

            public string CorreoElectronico
            {
                get { return correoElectronico; }
                set { if (!string.IsNullOrEmpty(value))
                    { correoElectronico = value; }
                }
            }

            private string direccion;

            public string Direccion
            {
                get { return direccion; }
                set { if (!string.IsNullOrEmpty(value))
                    { direccion = value; }
                }
            }

            private int cantidadPedidos;

            public int CantidadPedidos
            {
                get { return cantidadPedidos; }
                set { if (value > 0)
                    { cantidadPedidos = value; }
                }
            }

           
            public override void MostrarInformacion()
            {
                Console.Write("Código: "); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(Codigo);
                Console.ResetColor();
                Console.Write("Nombre: "); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(Nombre);
                Console.ResetColor();
                Console.Write("Número de Teléfono: "); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(NumeroTelefono);
                Console.ResetColor();
                Console.Write("Correo Electrónico: "); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(CorreoElectronico);
                Console.ResetColor();
                Console.Write("Dirección: "); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(Direccion);
                Console.ResetColor();
                Console.Write("Cantidad de Pedidos: "); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(CantidadPedidos);
                Console.ResetColor();
            }

            public Cliente(int codigo, string nombre, string numeroTelefono, string correoElectronico, string direccion, int cantidadPersonas)
               : base(codigo, nombre, numeroTelefono)
            {
                CorreoElectronico = correoElectronico;
                Direccion = direccion;
                CantidadPedidos = cantidadPersonas;
            }

        }

        class Repartidor : Persona
        {
            private char tipoLicencia;

            public char TipoLicencia
            {
                get { return tipoLicencia; }
                set { tipoLicencia = value; }
            }

            private bool disponibilidad;

            public bool Disponibilidad
            {
                get { return disponibilidad; }
                set { disponibilidad = value; }
            }

            private int cantidadEntregas;

            public int CantidadEntregas
            {
                get { return cantidadEntregas; }
                set { if (value >= 0)
                    { cantidadEntregas = value; }
                }
            }

            private double calificacion;

            public double Calificacion
            {
                get { return calificacion; }
                set { if (value >= 0 && value <= 5)
                    { calificacion = value; }
                }
            }

            public override void MostrarInformacion()
            {
                Console.Write("Código: "); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(Codigo);
                Console.ResetColor();
                Console.Write("Nombre: "); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(Nombre);
                Console.ResetColor();
                Console.Write("Número de Teléfono: "); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(NumeroTelefono);
                Console.ResetColor();
                Console.Write("Tipo de Licencia: "); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(TipoLicencia);
                Console.ResetColor();
                Console.Write("Cantidad de Entregas: "); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(CantidadEntregas);
                Console.ResetColor();
                Console.Write("Calificación: "); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(Calificacion);
                Console.ResetColor();
            }

            public Repartidor(int codigo, string nombre, string numeroTelefono, char tipoLicencia, bool disponibilidad, int cantidadEntregas, double calificacion)
                : base(codigo, nombre, numeroTelefono)
            {
                TipoLicencia = tipoLicencia;
                Disponibilidad = disponibilidad;
                CantidadEntregas = cantidadEntregas;
                Calificacion = calificacion;
            }
        }

        class Paquete
        {
            private int codigo;

            public int Codigo
            {
                get { return codigo; }
                set { if (value > 0)
                    { codigo = value; }
                }
            }

            private Cliente propietario;
            public Cliente Propietario
            {
                get
                {
                    return propietario;
                }
                set
                {
                    if (value != null)
                    {
                        propietario = value;
                    }
                }
            }

            private string descripcion;

            public string Descripcion
            {
                get { return descripcion; }
                set { if (!string.IsNullOrEmpty(value))
                    { descripcion = value; }
                }
            }

            private double peso;

            public double Peso
            {
                get { return  peso; }
                set { if (value > 0)
                    { peso = value; }
                }
            }

            private double valorDeclarado;

            public double ValorDeclarado
            {
                get { return  valorDeclarado; }
                set { if (value > 0)
                    { valorDeclarado = value; }
                }
            }

            private string direccionOrigen;

            public string DireccionOrigen
            {
                get { return direccionOrigen; }
                set { if (!string.IsNullOrEmpty(value))
                    { direccionOrigen = value; }
                }
            }

            private string direccionDestino;

            public string DireccionDestino
            {
                get { return direccionDestino; }
                set { if (!string.IsNullOrEmpty(value))
                    { direccionDestino = value; }
                }
            }

            public virtual void CalcularDistancia(string Origen, string Destino)
            {
                // no sabemos ni vrga
            
            }

            public virtual void CalcularTarifa (double Peso, double Valor)
            { // no vrg
            }

            public Paquete(int codigo, Cliente propietario, string descripcion, double peso, double valorDeclarado, string direccionOrigen, string direccionDestino)
            {
                Codigo = codigo;
                Propietario = propietario;
                Descripcion = descripcion;
                Peso = peso;
                ValorDeclarado = valorDeclarado;
                DireccionOrigen = direccionOrigen;
                DireccionDestino = direccionDestino;
            }

        }

       
        class Documento : Paquete
            {
                public Documento(
                    int codigo, Cliente propietario, string descripcion, double peso, double valorDeclarado, string direccionOrigen, string direccionDestino)
                    : base( codigo, propietario, descripcion, peso,  valorDeclarado, direccionOrigen, direccionDestino)
                {
                }

                public override void CalcularDistancia(string Origen, string Destino)
                {
                }

                public override void CalcularTarifa(double Peso, double Valor)
                {
                }
                         
            }

                
        class Estandar : Paquete
        {
        public Estandar(
                   int codigo, Cliente propietario, string descripcion, double peso, double valorDeclarado, string direccionOrigen, string direccionDestino)
                   : base(codigo, propietario, descripcion, peso, valorDeclarado, direccionOrigen, direccionDestino)
        {
        }
        public override void CalcularDistancia(string Origen, string Destino)
            {
                // no sabemos ni vrga

            }
            public override void CalcularTarifa(double Peso, double Valor)
            { // no vrg
            }
        }

        class Fragil : Paquete
        {
        public Fragil(
                    int codigo, Cliente propietario, string descripcion, double peso, double valorDeclarado, string direccionOrigen, string direccionDestino)
                    : base(codigo, propietario, descripcion, peso, valorDeclarado, direccionOrigen, direccionDestino)
        {
        }
        public override void CalcularDistancia(string Origen, string Destino)
            {
                // no sabemos ni vrga

            }
            public override void CalcularTarifa(double Peso, double Valor)
            { // no vrg
            }
        }

        class Vehiculo
        {
            private string  placa;

            public string  Placa
            {
                get { return placa; }
                set { if (!string.IsNullOrEmpty(value))
                    { placa = value; }
                }
            }

            private string  marca;

            public string  Marca
            {
                get { return marca; }
                set { if (!string.IsNullOrEmpty(value))
                    { marca = value; }
                }
            }

            private string modelo;

            public string Modelo
            {
                get { return modelo; }
                set {
                    if (!string.IsNullOrEmpty(value))
                    { modelo = value; }
                }
            }

            private double  capacidadCarga;

            public double  CapacidadCarga
            {
                get { return capacidadCarga; }
                set { if (value > 0)
                    { capacidadCarga = value; }
                }
            }

           public enum estadoVehiculo
            {Disponible, Asignado, Mantenimiento }

            private estadoVehiculo estado;

            public estadoVehiculo Estado
            {
                get { return estado; }
                set { if (Enum.IsDefined(typeof(estadoVehiculo), value))
                    { estado = value; }
                }
            }

            private double costo;

            public double Costo
            {
                get { return costo; }
                set { if (value > 0)
                    { costo = value; }
                }
            }

            public virtual void MostrarInformacion()
            {
                Console.Write("Placa: "); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(Placa); Console.ResetColor();
                Console.Write("Marca: "); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(Marca);Console.ResetColor();
                Console.Write("Modelo: "); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(Modelo);Console.ResetColor();
                Console.Write("Capacidad de Carga: ");  Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(CapacidadCarga); Console.ResetColor();
                Console.Write("Estado: "); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(Estado); Console.ResetColor();
                Console.Write("Costo: "); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(Costo); Console.ResetColor();
            }

            public virtual void CalcularPrecio()
            { }

            public Vehiculo(string placa, string marca, string modelo, double capacidadCarga, estadoVehiculo estado, double costo)
            {
                Placa = placa;
                Marca = marca;
                Modelo = modelo;
                CapacidadCarga = capacidadCarga;
                Estado = estado;
                Costo = costo;
            }
        }
        
         class Bicicleta : Vehiculo
            {
                public Bicicleta(
                    string placa, string marca, string modelo, double capacidadCarga, estadoVehiculo estado, double costo) 
                    : base(placa, marca, modelo, capacidadCarga, estado, costo)
                {
                }

                public override void MostrarInformacion()
                {
                    base.MostrarInformacion();
                }

                public override void CalcularPrecio()
                {
                }
            }        

        class Motocicleta : Vehiculo
        {
        public Motocicleta(
                    string placa, string marca, string modelo, double capacidadCarga, estadoVehiculo estado, double costo)
                    : base(placa, marca, modelo, capacidadCarga, estado, costo)
        {
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
        }
        public override void CalcularPrecio()
            { }
        }

        class Automovil : Vehiculo
        {
        public Automovil(
                string placa, string marca, string modelo, double capacidadCarga, estadoVehiculo estado, double costo)
                : base(placa, marca, modelo, capacidadCarga, estado, costo)
        {
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
        }
        public override void CalcularPrecio()
            { }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            //variables
            int opcion;
            string nombre, numeroTelefono;

            List<Cliente> clientes = new List<Cliente>();
            List<Repartidor> repartidores = new List<Repartidor>();
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            List<Paquete> paquetes = new List<Paquete>();

            List<int> id = new List<int>();
            Random IDrand = new Random();

            //funciones y procedimentos

            void Titulo(string texto, ConsoleColor colorFondo)
            {
                Console.Clear();
                Console.ResetColor();
                int ancho = 100;
                Console.BackgroundColor = colorFondo;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(new string('=', ancho));
                int espacios = (ancho - texto.Length) / 2;
                Console.WriteLine(new string(' ', espacios) + texto + new string(' ', espacios));
                Console.WriteLine(new string('=', ancho));
                Console.ResetColor();
                Console.WriteLine();
            }

            void OpcionMenu(string numero, string texto, ConsoleColor colorTex )
            {
                Console.ForegroundColor = colorTex;
                Console.Write("  [" + numero + "] ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(texto);
                Console.ResetColor();
            }

            void MensajeExito(string mensaje)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("  ✓ CORRECTO:  " + mensaje);
                Console.ResetColor();
            }

            void MensajeError(string mensaje)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("  ✘ ERROR:  " + mensaje);
                Console.ResetColor();
            }

            void Pausa()
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Presione cualquier tecla para continuar....................");
                Console.ResetColor();
                Console.ReadKey();
            }

            void MenuPrincipal()
            {
                do
                {
                    Titulo("X E L A  D R I V E R", ConsoleColor.DarkBlue);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine("                                 SISTEMA DE GESTIÓN DE ENTREGAS");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine("────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();

                    OpcionMenu("1", "Gestión de Clientes", ConsoleColor.Blue);
                    OpcionMenu("2", "Gestión de Repartidores", ConsoleColor.Blue);
                    OpcionMenu("3", "Gestión de Vehículos", ConsoleColor.Blue);
                    OpcionMenu("4", "Gestión de Paquetes", ConsoleColor.Blue);
                    OpcionMenu("5", "Gestión de Entregas", ConsoleColor.Blue);
                    OpcionMenu("6", "Gestión de Incidencias", ConsoleColor.Blue);
                    OpcionMenu("7", "Reportes", ConsoleColor.Blue);

                    Console.WriteLine();

                    OpcionMenu("8", "Salir", ConsoleColor.DarkRed);

                    Console.WriteLine();
                    Console.WriteLine("────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Seleccione una opción: ");
                    Console.ResetColor();

                    if (!int.TryParse(Console.ReadLine(), out opcion))
                    {
                        MensajeError("Ingrese la opción utilizando números enteros.");
                        Pausa();
                    }else { break; }
                } while (true);

                switch (opcion)
                    {
                        case 1:
                            MenuClientes();
                            break;

                        case 2:
                            MenuRepartidor();
                            break;

                        case 3:
                            MenuVehiculo();
                            break;

                        case 4:
                            MensajeError("Módulo en desarrollo.");
                            Pausa();
                            break;

                        case 5:
                            MensajeError("Módulo en desarrollo.");
                            Pausa();
                            break;

                        case 6:
                            MensajeError("Módulo en desarrollo.");
                            Pausa();
                            break;

                        case 7:
                            MensajeError("Módulo en desarrollo.");
                            Pausa();
                            break;

                        case 8:

                            Console.Clear();

                            Console.ForegroundColor = ConsoleColor.Green;

                            Console.WriteLine();
                            Console.WriteLine(@"             
                                                 Gracias por utilizar XelaDriver

                                                        ¡Hasta pronto!");

                            Console.ResetColor();
                            break;

                        default:
                            MensajeError("La opción seleccionada no existe.");
                            Pausa();
                        MenuPrincipal();
                        break;
                }
            }
            int GenerarID()
            {
                int NuevoID = IDrand.Next(10000, 99999);
                foreach (int i in id)
                {
                    if (i == NuevoID)
                    {
                        return GenerarID();
                    }
                }
                id.Add(NuevoID);
                return NuevoID;
            }

            bool ValidarCliente(Cliente objeto, string nombrec, string telefono, string correo, string direccion)
            {
                if (objeto.Nombre != nombrec)
                {
                    MensajeError("El nombre ingresado no es válido.");
                    return false;
                }

                if (objeto.NumeroTelefono != telefono)
                {
                    MensajeError("El número de teléfono ingresado no es válido.");
                    return false;
                }

                if (objeto.CorreoElectronico != correo)
                {
                    MensajeError("El correo electrónico ingresado no es válido.");
                    return false;
                }

                if (objeto.Direccion != direccion)
                {
                    MensajeError("La dirección ingresada no es válida.");
                    return false;
                }

                return true;
            }


            bool ValidarRepartidor(Repartidor objeto, string nombrer, string telefono, char tipoLicencia,  int entregas)
            {
                if (objeto.Nombre != nombrer)
                {
                    MensajeError("El nombre ingresado no es válido.");
                    return false;
                }

                if (objeto.NumeroTelefono != telefono)
                {
                    MensajeError("El número de teléfono ingresado no es válido.");
                    return false;
                }

                if (objeto.TipoLicencia != tipoLicencia)
                {
                    MensajeError("El tipo de licencia ingresado no es válido.");
                    return false;
                }

                if (objeto.CantidadEntregas != entregas)
                {
                    MensajeError("La cantidad de entregas ingresada no es válida.");
                    return false;
                }

                return true;
            }

           

             bool ValidarVehiculo(Vehiculo objeto, string placa, string marca, string modelo, double capacidad, Vehiculo.estadoVehiculo estado, double costo)
            {
                if (objeto.Placa != placa)
                {
                    MensajeError("La placa ingresada no es válida.");
                    return false;
                }

                if (objeto.Marca != marca)
                {
                    MensajeError("La marca ingresada no es válida.");
                    return false;
                }

                if (objeto.Modelo != modelo)
                {
                    MensajeError("El modelo ingresado no es válido.");
                    return false;
                }

                if (objeto.CapacidadCarga != capacidad)
                {
                    MensajeError("La capacidad de carga ingresada no es válida.");
                    return false;
                }

                if (objeto.Estado != estado)
                {
                    MensajeError("El estado ingresado no es válido.");
                    return false;
                }

                if (objeto.Costo != costo)
                {
                    MensajeError("El costo ingresado no es válido.");
                    return false;
                }

                return true;
             }

                
            void MenuClientes()
            {
                string correo, direccion;

                do
                {

                    Titulo("MENÚ  CLIENTES", ConsoleColor.DarkMagenta);
                    Console.WriteLine();
                    Console.WriteLine("────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();

                    OpcionMenu("1", "Agregar nuevo cliente", ConsoleColor.Magenta);
                    OpcionMenu("2", "Ver lista de clientes", ConsoleColor.Magenta);
                    OpcionMenu("3", "Actualizar cliente existente", ConsoleColor.Magenta);
                    Console.WriteLine();
                    OpcionMenu("4", "Regresar", ConsoleColor.DarkRed);

                    Console.WriteLine();
                    Console.WriteLine("────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Seleccione una opción: ");
                    Console.ResetColor();
                    
                    
                    if (!int.TryParse(Console.ReadLine(), out opcion))
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ingrese su opcion en numeros enteros");
                        Console.ResetColor();
                    }
                    else
                    {
                        break;
                    }
                } while (true);
                bool clienteValido = false;
                switch (opcion)
                {
                    
                    case 1:
                        
                        do
                        {
                            do
                            {
                                Console.Write("Ingrese el nombre: ");
                                nombre = Console.ReadLine();
                                if (!string.IsNullOrEmpty(nombre))
                                {
                                    break;
                                }
                                MensajeError("El nombre no puede estar vacío");
                            } while (true);

                            do
                            {
                                Console.Write("Ingrese el número de teléfono: ");
                                numeroTelefono = Console.ReadLine();
                                if (string.IsNullOrEmpty(numeroTelefono))
                                {
                                    MensajeError("Número de teléfono no puede estar vacío");
                                }
                                else if (numeroTelefono.Length != 8)
                                {
                                    MensajeError("Número de teléfono debe tener exactamente 8 dígitos");
                                }
                                else
                                {
                                    break;
                                }
                            } while (true);

                            do
                            {
                                Console.Write("Ingrese el correo electrónico: ");
                                correo = Console.ReadLine();
                                if (!string.IsNullOrEmpty(correo))
                                {
                                    break;
                                }
                                MensajeError("El correo no puede estar vacío");
                            } while (true);

                            do
                            {
                                Console.Write("Ingrese la dirección: ");
                                direccion = Console.ReadLine();

                                if (!string.IsNullOrEmpty(direccion))
                                {
                                    break;
                                }

                                MensajeError("La dirección no puede estar vacio");

                            } while (true);


                            //Agregar validaciones

                            Cliente cliente = new Cliente(GenerarID(), nombre, numeroTelefono, correo, direccion, 1);

                            clienteValido = ValidarCliente(cliente, nombre, numeroTelefono, correo, direccion);

                            if (clienteValido)
                            {
                                clientes.Add(cliente);
                                MensajeExito("Cliente agregado ");
                            }
                        } while (!clienteValido);
                        Pausa();
                        MenuClientes();
                        break;
                    case 2:
                        if (clientes.Count == 0)
                        {
                            MensajeError("No se han ingresado datos de clientes");
                            Pausa();
                        }
                        else
                        {
                            foreach (Cliente objeto in clientes)
                            {
                                objeto.MostrarInformacion();
                                Console.WriteLine();
                            }
                            Pausa();
                        }
                        MenuClientes();
                        break;
                    case 3:
                        int codigo;
                        Console.ResetColor();
                        if (clientes.Count == 0)
                        {
                            MensajeError("No se han ingresado datos de clientes");
                            Pausa();
                        }
                        else
                        {
                            foreach (Cliente objeto in clientes)
                            {
                                objeto.MostrarInformacion();
                                Console.WriteLine();
                            }
                            do
                            {

                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("Seleccione el codigo del cliente: ");
                                Console.ResetColor();
                                if (!int.TryParse(Console.ReadLine(), out codigo))
                                {
                                    MensajeError("Ingrese el codigo solo con numeros");
                                    Console.WriteLine();
                                }
                                else { break; }
                            } while (true);
                            int posicion = clientes.FindIndex(p => p.Codigo == codigo);
                            if (posicion == -1)
                            {
                                MensajeError("No existe un cliente con ese código");
                                Pausa();
                                MenuClientes();
                                break;
                            }
                            do
                            {
                                do
                                {
                                    Console.Write("Ingrese el nuevo nombre: ");
                                    nombre = Console.ReadLine();
                                    if (!string.IsNullOrEmpty(nombre))
                                    {
                                        break;
                                    }
                                    MensajeError("El nombre no puede estar vacío");
                                } while (true);

                                do
                                {
                                    Console.Write("Ingrese el nuevo número de teléfono: ");
                                    numeroTelefono = Console.ReadLine();
                                    if (string.IsNullOrEmpty(numeroTelefono))
                                    {
                                        MensajeError("Número de teléfono no puede estar vacío");
                                    }
                                    else if (numeroTelefono.Length != 8)
                                    {
                                        MensajeError("Número de teléfono debe tener exactamente 8 dígitos");
                                    }
                                    else
                                    {
                                        break;
                                    }
                                } while (true);

                                do
                                {
                                    Console.Write("Ingrese el nuevo correo electrónico: ");
                                    correo = Console.ReadLine();
                                    if (!string.IsNullOrEmpty(correo))
                                    {
                                        break;
                                    }
                                    MensajeError("El correo no puede estar vacío");
                                } while (true);

                                do
                                {
                                    Console.Write("Ingrese la nueva dirección: ");
                                    direccion = Console.ReadLine();

                                    if (!string.IsNullOrEmpty(direccion))
                                    {
                                        break;
                                    }

                                    MensajeError("La dirección no puede estar vacia");

                                } while (true);

                                clientes[posicion].Nombre = nombre;
                                clientes[posicion].NumeroTelefono = numeroTelefono;
                                clientes[posicion].CorreoElectronico = correo;
                                clientes[posicion].Direccion = direccion;

                                clienteValido = ValidarCliente(clientes[posicion], nombre, numeroTelefono, correo, direccion);

                            } while (!clienteValido); ;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Datos actualizados");
                        }
                        MenuClientes();
                        break;
                    case 4:
                        MenuPrincipal();
                        break;
                    default:
                        Console.ResetColor();
                        MensajeError("La opcion seleeccionada no es valida.");
                        Pausa();
                        MenuClientes();
                        break;
                }
            }
            void MenuRepartidor()
            {
                char licencia;
                bool disponibilidad = true, repartidorValido; 
                int entregas = 0;
                double calificacionPromedio, calificacion = 0;

                do
                {
                    Titulo("MENÚ  REPARTIDORES", ConsoleColor.DarkMagenta);
                    Console.WriteLine();
                    Console.WriteLine("────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();

                    OpcionMenu("1", "Agregar nuevo repartidor", ConsoleColor.Magenta);
                    OpcionMenu("2", "Consultar lista de repartidores", ConsoleColor.Magenta);
                    OpcionMenu("3", "Actualizar repartidor existente", ConsoleColor.Magenta);
                    OpcionMenu("4", "Cambiar disponibilidad", ConsoleColor.Magenta);
                    Console.WriteLine();
                    OpcionMenu("5", "Regresar", ConsoleColor.DarkRed);

                    Console.WriteLine();
                    Console.WriteLine("────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Seleccione una opción: ");
                    Console.ResetColor();

                    if (!int.TryParse(Console.ReadLine(), out opcion))
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ingrese su opcion en numeros enteros");
                        Console.ResetColor();
                    }
                    else
                    {
                        break;
                    }
                } while (true);


                switch (opcion)
                {

                    case 1:
                        do
                        {
                            do
                            {
                                Console.Write("Ingrese el nombre: ");
                                nombre = Console.ReadLine();
                                if (!string.IsNullOrEmpty(nombre))
                                {
                                    break;
                                }
                                MensajeError("El nombre no puede estar vacío");
                            } while (true);


                            do
                            {
                                Console.Write("Ingrese el número de teléfono: ");
                                numeroTelefono = Console.ReadLine();
                                if (string.IsNullOrEmpty(numeroTelefono))
                                {
                                    MensajeError("Número de teléfono no puede estar vacío");
                                }
                                else if (numeroTelefono.Length != 8)
                                {
                                    MensajeError("Número de teléfono debe tener exactamente 8 dígitos");
                                }
                                else
                                {
                                    break;
                                }
                            } while (true);
                            do
                            {
                                Console.WriteLine("Ingrese el tipo de licencia:");
                                OpcionMenu("A", "Licencia tipo A", ConsoleColor.Yellow);
                                OpcionMenu("B", "Licencia tipo B", ConsoleColor.Yellow);
                                OpcionMenu("C", "Licencia tipo C", ConsoleColor.Yellow);
                                OpcionMenu("M", "Licencia tipo M", ConsoleColor.Yellow);
                                OpcionMenu("N/A", "No aplica", ConsoleColor.Yellow);
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("Seleccione una opción: ");
                                Console.ResetColor();
                                string entradaLicencia = Console.ReadLine().ToUpper().Trim();

                                if (entradaLicencia == "A" || entradaLicencia == "B" || entradaLicencia == "C" || entradaLicencia == "M")
                                {
                                    licencia = char.Parse(entradaLicencia.ToUpper());
                                    break;
                                }
                                else if (entradaLicencia == "N/A")
                                {
                                    licencia = 'N';
                                    break;
                                }
                                else if (string.IsNullOrEmpty(entradaLicencia))
                                {
                                    MensajeError("Licencia no puede estar vacía");
                                }
                                else
                                {
                                    MensajeError("Opción de licencia no válida");
                                }

                            }
                            while (true);
                            //Agregar una forma de calcular el promedio, que se actualize solo
                            //Agregar validaciones

                            do
                            {
                                Console.Write("Ingrese cantidad de entregas: ");

                                if (int.TryParse(Console.ReadLine(), out entregas) && entregas >= 0)
                                {
                                    break;
                                }

                                MensajeError("Cantidad de entregas debe ser un número entero");

                            } while (true);



                            Repartidor repartidor = new Repartidor(GenerarID(), nombre, numeroTelefono, licencia, disponibilidad, entregas, 0);

                            repartidorValido = ValidarRepartidor(repartidor, nombre, numeroTelefono, licencia, entregas);

                            if (repartidorValido)
                            {
                                repartidores.Add(repartidor);
                                MensajeExito("Repartidor agregado ");
                            }
                        } while (!repartidorValido);
                
                    Pausa();
                    MenuRepartidor();
                break;
                  
                    case 2:
                        if (repartidores.Count == 0)
                        {
                            MensajeError("No se han ingresado datos de repartidores");
                            Pausa();
                        }
                        else
                        {
                            foreach (Repartidor objeto in repartidores)
                            {
                                objeto.MostrarInformacion();
                                Console.WriteLine();
                            }
                            Pausa();}
                        MenuRepartidor();
                        break;
                    case 3:
                        int codigo; 
                        if (repartidores.Count == 0)
                        {
                            MensajeError("No se han ingresado datos de repartidores");
                            Pausa();
                        }
                        else
                        {
                            do
                            {
                                Console.ResetColor();
                                foreach (Repartidor objeto in repartidores)
                                {
                                    objeto.MostrarInformacion();
                                    Console.WriteLine();
                                }
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("Seleccione el codigo del repartidor: ");
                                Console.ResetColor();
                                if (!int.TryParse(Console.ReadLine(), out codigo))
                                {
                                    MensajeError("Ingrese el codigo solo con numeros.");
                                }
                                else { break; }
                            } while (true);
                            int posicion = repartidores.FindIndex(p => p.Codigo == codigo);
                            if (posicion == -1)
                            {
                                MensajeError("No existe un repartidor con ese código");
                                Pausa();
                                MenuRepartidor();
                                break;
                            }
                            do
                            {
                                do
                                {
                                    Console.Write("Ingrese el nuevo nombre: ");
                                    nombre = Console.ReadLine();
                                    if (!string.IsNullOrEmpty(nombre))
                                    {
                                        break;
                                    }
                                    MensajeError("El nombre no puede estar vacío");
                                } while (true);


                                do
                                {
                                    Console.Write("Ingrese el nuevo número de teléfono: ");
                                    numeroTelefono = Console.ReadLine();
                                    if (string.IsNullOrEmpty(numeroTelefono))
                                    {
                                        MensajeError("Número de teléfono no puede estar vacío");
                                    }
                                    else if (numeroTelefono.Length != 8)
                                    {
                                        MensajeError("Número de teléfono debe tener exactamente 8 dígitos");
                                    }
                                    else
                                    {
                                        break;
                                    }
                                } while (true);
                                do
                                {
                                    Console.WriteLine("Ingrese el tipo de licencia:");
                                    OpcionMenu("A", "Licencia tipo A", ConsoleColor.Yellow);
                                    OpcionMenu("B", "Licencia tipo B", ConsoleColor.Yellow);
                                    OpcionMenu("C", "Licencia tipo C", ConsoleColor.Yellow);
                                    OpcionMenu("M", "Licencia tipo M", ConsoleColor.Yellow);
                                    OpcionMenu("N/A", "No aplica", ConsoleColor.Yellow);
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("Seleccione una opción: ");
                                    Console.ResetColor();
                                    string entradaLicencia = Console.ReadLine().ToUpper().Trim();

                                    if (entradaLicencia == "A" || entradaLicencia == "B" || entradaLicencia == "C" || entradaLicencia == "M")
                                    {
                                        licencia = char.Parse(entradaLicencia.ToUpper());
                                        break;
                                    }
                                    else if (entradaLicencia == "N/A")
                                    {
                                        licencia = 'N';
                                        break;
                                    }
                                    else if (string.IsNullOrEmpty(entradaLicencia))
                                    {
                                        MensajeError("Licencia no puede estar vacía");
                                    }
                                    else
                                    {
                                        MensajeError("Opción de licencia no válida");
                                    }

                                }
                                while (true);
                                //Agregar una forma de calcular el promedio, que se actualize solo
                                //Agregar validaciones

                                do
                                {
                                    Console.Write("Ingrese la nueva cantidad de entregas: ");

                                    if (int.TryParse(Console.ReadLine(), out entregas) && entregas >= 0)
                                    {
                                        break;
                                    }

                                    MensajeError("Cantidad de entregas debe ser un número entero");

                                } while (true);

                                repartidores[posicion].Nombre = nombre;
                                repartidores[posicion].NumeroTelefono = numeroTelefono;
                                repartidores[posicion].TipoLicencia = licencia;

                                repartidorValido = ValidarRepartidor(repartidores[posicion], nombre, numeroTelefono, licencia, entregas);

                            } while (!repartidorValido);

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Datos actualizados");
                            Pausa();
                        }
                        MenuRepartidor();
                        break;
                    case 4:
                        //nose agregar un metodo para cambiar la disponibilidad
                        Console.WriteLine("Se modigicara eso pronto...");
                        Pausa();
                        MenuRepartidor();
                        break;
                    case 5:
                        MenuPrincipal();
                        break;
                    default:
                        Console.ResetColor();
                        Pausa();
                        MensajeError("La opción seleccionada no existe");
                        MenuRepartidor();
                        break;
                }
            }
            void MenuTipoVehiculo(int nuevo)
            {
                string placaVehiculo = "", marcaVehiculo, modeloVehiculo;
                double capacidadCargaVehiculo, costoVehiculo;
                Vehiculo.estadoVehiculo estado;
                int opcionVehiculo;
                bool vehiculoValido = false;
                do
                {

                    do
                    {
                        Titulo("TIPO DE VEHICULO", ConsoleColor.DarkMagenta);
                        Console.WriteLine();
                        OpcionMenu("1", "Bicicleta", ConsoleColor.Magenta);
                        OpcionMenu("2", "Motocicleta", ConsoleColor.Magenta);
                        OpcionMenu("3", "Automóvil", ConsoleColor.Magenta);
                        Console.WriteLine();
                        OpcionMenu("4", "Regresar", ConsoleColor.DarkRed);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Seleccione una opción: ");
                        Console.ResetColor();

                        if (!int.TryParse(Console.ReadLine(), out opcionVehiculo))
                        {
                            MensajeError("Ingrese una opción válida");
                            Pausa();
                        }

                        else if (opcionVehiculo < 1 || opcionVehiculo > 4)
                        {
                            MensajeError("La opción seleccionada no existe");
                            Pausa();
                        }
                        else
                        {
                            break;
                        }

                    } while (true);
                    if (opcionVehiculo == 4)
                    {
                        MenuVehiculo();
                        
                    }
                    else
                    { 
                        if(nuevo == -1)
                        {
                            do
                            {
                                Console.Write("Ingrese la placa del vehiculo: ");
                                placaVehiculo = Console.ReadLine();
                                if (!string.IsNullOrEmpty(placaVehiculo))
                                {
                                    break;
                                }
                                MensajeError("La placa no puede estar vacía");
                            } while (true);
                        }

                    do
                    {
                        Console.Write("Ingrese la marca del vehiculo: ");
                        marcaVehiculo = Console.ReadLine();
                        if (!string.IsNullOrEmpty(marcaVehiculo))
                        {
                            break;
                        }
                        MensajeError("La marca no puede estar vacía");
                    } while (true);

                    do
                    {
                        Console.Write("Ingrese el modelo del vehiculo: ");
                        modeloVehiculo = Console.ReadLine();
                        if (!string.IsNullOrEmpty(modeloVehiculo))
                        {
                            break;
                        }
                        MensajeError("El modelo no puede estar vacío");
                    } while (true);

                    do
                    {
                        Console.Write("Ingrese la capacidad de carga del vehiculo: ");
                        if (!double.TryParse(Console.ReadLine(), out capacidadCargaVehiculo))
                        {
                            MensajeError("Ingrese un valor numérico válido para la capacidad de carga");
                        }
                        else if (capacidadCargaVehiculo <= 0)
                        {
                            MensajeError("La capacidad de carga debe ser mayor a cero");
                        }
                        else
                        { break; }

                    } while (true);

                    int opcionEstado;


                    do
                    {
                        OpcionMenu("1", "Disponible", ConsoleColor.Cyan);
                        OpcionMenu("2", "Asignado", ConsoleColor.Cyan);
                        OpcionMenu("3", "Mantenimiento", ConsoleColor.Cyan);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Seleccione el estado del vehículo: ");
                        Console.ResetColor();

                        if (!int.TryParse(Console.ReadLine(), out opcionEstado))
                        {
                            MensajeError("Ingrese una opción numérica válida");
                        }
                        else if (opcionEstado < 1 || opcionEstado > 3)
                        {
                            MensajeError("La opción seleccionada no existe");
                        }
                        else
                        {
                            break;
                        }

                    } while (true);
                    estado = (Vehiculo.estadoVehiculo)(opcionEstado - 1);

                    do
                    {
                        Console.Write("Ingrese el costo del vehiculo: ");
                        if (!double.TryParse(Console.ReadLine(), out costoVehiculo))
                        {
                            MensajeError("Ingrese un valor numérico válido para el costo");
                        }
                        else if (costoVehiculo <= 0)
                        {
                            MensajeError("El costo debe ser mayor a cero");
                        }
                        else
                        { break; }

                    } while (true);

                        if (nuevo == -1)
                        {
                            Vehiculo vehiculo;

                            if (opcionVehiculo == 1)
                            {
                                vehiculo = new Bicicleta(placaVehiculo, marcaVehiculo, modeloVehiculo, capacidadCargaVehiculo, estado, costoVehiculo);
                            }
                            else if (opcionVehiculo == 2)
                            {
                                vehiculo = new Motocicleta(placaVehiculo, marcaVehiculo, modeloVehiculo, capacidadCargaVehiculo, estado, costoVehiculo);
                            }
                            else
                            {
                                vehiculo = new Automovil(placaVehiculo, marcaVehiculo, modeloVehiculo, capacidadCargaVehiculo, estado, costoVehiculo);
                            }

                            vehiculoValido = ValidarVehiculo(vehiculo, placaVehiculo, marcaVehiculo, modeloVehiculo, capacidadCargaVehiculo, estado, costoVehiculo);

                            if (vehiculoValido)
                            {
                                vehiculos.Add(vehiculo);
                                MensajeExito("Vehículo agregado ");
                            }
                            Pausa();
                            MenuVehiculo();
                        }
                        else
                        {

                            vehiculos[nuevo].Marca = marcaVehiculo;
                            vehiculos[nuevo].Modelo = modeloVehiculo;
                            vehiculos[nuevo].CapacidadCarga = capacidadCargaVehiculo;
                            vehiculos[nuevo].Estado = estado;
                            vehiculos[nuevo].Costo = costoVehiculo;

                            vehiculoValido = ValidarVehiculo(vehiculos[nuevo], vehiculos[nuevo].Placa, marcaVehiculo, modeloVehiculo, capacidadCargaVehiculo, estado, costoVehiculo);

                        }
                    }

                } while (!vehiculoValido) ; 
               
            }

            

            void MenuVehiculo()
            {

                do
                {
                    Titulo("MENÚ  VEHICULO", ConsoleColor.DarkMagenta);
                    Console.WriteLine();
                    Console.WriteLine("────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();

                    OpcionMenu("1", "Agregar nuevo vehiculo", ConsoleColor.Magenta);
                    OpcionMenu("2", "Consultar lista de vehiculos", ConsoleColor.Magenta);
                    OpcionMenu("3", "Actualizar vehiculo existente", ConsoleColor.Magenta);
                    Console.WriteLine();
                    OpcionMenu("4", "Regresar", ConsoleColor.DarkRed);

                    Console.WriteLine();
                    Console.WriteLine("────────────────────────────────────────────────────────────────────────────────────────────────────");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Seleccione una opción: ");
                    Console.ResetColor();

                    if (!int.TryParse(Console.ReadLine(), out opcion))
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ingrese su opcion en numeros enteros");
                        Console.ResetColor();
                    }
                    else
                    {
                        break;
                    }
                } while (true);

                switch (opcion)
                {

                    case 1:
                        MenuTipoVehiculo(-1);
                        break;
                    case 2:
                        if (vehiculos.Count == 0)
                        {
                            MensajeError("No se han ingresado datos de vehículos");
                            Pausa();
                        }
                        else
                        {
                            foreach (Vehiculo objeto in vehiculos)
                            {
                                objeto.MostrarInformacion();
                                Console.WriteLine();
                            }
                            Pausa();
                        }
                        
                        MenuVehiculo();
                        break;
                    case 3:
                        string codigo;
                        if (vehiculos.Count == 0)
                        {
                            MensajeError("No se han ingresado datos de vehículos");
                        }
                        else
                        {
                           
                                Console.ResetColor();
                                foreach (Vehiculo objeto in vehiculos)
                                {
                                    objeto.MostrarInformacion();
                                    Console.WriteLine();
                                }
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("Seleccione la placa del vehiculo: ");
                                Console.ResetColor();
                                codigo = Console.ReadLine();

                            int posicion = vehiculos.FindIndex(p => p.Placa == codigo);
                            if (posicion == -1)
                            {
                                MensajeError("No existe un vehiculo con esa placa");
                                Pausa();
                                MenuVehiculo();
                                break;
                            }
                            MenuTipoVehiculo(posicion);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Datos actualizados");
                        }
                        Pausa();
                        MenuVehiculo();
                        break;
                    case 4:
                        
                        MenuPrincipal();
                        break;
                    default:
                        Console.ResetColor();
                        Pausa();
                        MensajeError("La opción seleccionada no existe");
                        MenuVehiculo();
                        break;
                }
            }

            //programa
            MenuPrincipal();
        }
    }
}
