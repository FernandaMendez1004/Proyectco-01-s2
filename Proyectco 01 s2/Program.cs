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
                Console.WriteLine("Placa: " + Placa);
                Console.WriteLine("Marca: " + Marca);
                Console.WriteLine("Modelo: " + Modelo);
                Console.WriteLine("Capacidad de Carga: " + CapacidadCarga);
                Console.WriteLine("Estado: " + Estado);
                Console.WriteLine("Costo: " + Costo);
            }

            public virtual void CalcularPrecio()
            { }

            public Vehiculo(
     string placa,
     string marca,
     string modelo,
     double capacidadCarga,
     estadoVehiculo estado,
     double costo)
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
                Console.WriteLine(new string(' ', espacios) + texto + " " + new string(' ', espacios));
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
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine("  ✓ " + mensaje);
                Console.ResetColor();
            }

            void MensajeError(string mensaje)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine();
                Console.WriteLine("  X ERROR: " + mensaje);
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
                    Titulo("X E L A D R I V E R", ConsoleColor.DarkBlue);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("                         SISTEMA DE GESTIÓN DE ENTREGAS");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine("────────────────────────────────────────────────────────────────────────────────");
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
                    Console.WriteLine("────────────────────────────────────────────────────────────────────────────────");
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
                            MensajeError("Módulo en desarrollo.");
                            Pausa();
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

            void MenuClientes()
            {
                string correo, direccion;

                do
                {
                    Titulo("M E N U  C L I E N T E S", ConsoleColor.DarkMagenta);
                    Console.WriteLine();
                    Console.WriteLine("────────────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine();

                    OpcionMenu("1", "Agregar nuevo cliente", ConsoleColor.Magenta);
                    OpcionMenu("2", "Ver lista de clientes", ConsoleColor.Magenta);
                    OpcionMenu("3", "Actualizar cliente existente", ConsoleColor.Magenta);
                    OpcionMenu("4", "Regresar", ConsoleColor.Magenta);

                    Console.WriteLine();
                    Console.WriteLine("────────────────────────────────────────────────────────────────────────────────");
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
                        Console.WriteLine("Ingresa el nombre:");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el numero de telefono:");
                        numeroTelefono = Console.ReadLine();
                        Console.WriteLine("Ingrese el correo electronico:");
                        correo = Console.ReadLine();
                        Console.WriteLine("Ingrese la direccion:");
                        direccion = Console.ReadLine();

                        //Agregar validaciones

                        Cliente cliente = new Cliente(GenerarID(), nombre, numeroTelefono, correo, direccion, 1);
                        clientes.Add(cliente);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Cliente agregado");
                        Console.ResetColor();
                        MenuClientes();
                        break;
                    case 2:
                        foreach (Cliente objeto in clientes)
                        {
                            objeto.MostrarInformacion();
                            Console.WriteLine();
                        }
                        Console.ReadKey();
                        MenuClientes();
                        break;
                    case 3:
                        int codigo;
                        do
                        {
                            Console.ResetColor();
                            foreach (Cliente objeto in clientes)
                            {
                                objeto.MostrarInformacion();
                            }
                            Console.WriteLine("Seleccione el codigo del cliente:");
                            if (!int.TryParse(Console.ReadLine(), out codigo))
                            {
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("ingrese el codigo solo con numeros");
                            }
                            else { break; }
                        } while (true);
                        int posicion = clientes.FindIndex(p => p.Codigo == codigo);
                        Console.WriteLine("Ingresa el Nuevo nombre:");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el nuevo numero de telefono:");
                        numeroTelefono = Console.ReadLine();
                        Console.WriteLine("Ingrese el nuevo correo electronico:");
                        correo = Console.ReadLine();
                        Console.WriteLine("Ingrese la nueva direccion:");
                        direccion = Console.ReadLine();
                        //implementar las validaciones
                        
                        clientes[posicion].Nombre = nombre;
                        clientes[posicion].NumeroTelefono = numeroTelefono;
                        clientes[posicion].CorreoElectronico = correo;
                        clientes[posicion].Direccion = direccion;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Datos actualizados");
                        MenuClientes();
                        break;
                    case 4:
                        MenuPrincipal();
                        break;
                    default:
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Opcion invalida");
                        Console.ResetColor();
                        MenuClientes();
                        break;
                }
            }
            void MenuRepartidor()
            {
                char licencia;
                bool disponibilidad = true;
                int entregas = 0;
                double calificacionPromedio, calificacion = 0;

                do
                {
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("======== Menu repartidores ========");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Seleccione una opcion: \n" +
                        "1. Registrar nuevo repartidor \n" +
                        "2. Consultar lista de repartidores\n" +
                        "3. Actualizar repartidor existente \n" +
                        "4. Cambiar disponibilidad \n" +
                        "5. Regresar al menu principal.");
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
                        Console.WriteLine("Ingresa el nombre:");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el numero de telefono:");
                        numeroTelefono = Console.ReadLine();
                        Console.WriteLine("Ingrese el tipo de licencia:");
                        // validar entrada
                        licencia = char.Parse(Console.ReadLine());
                        //Agregar una forma de calcular el promedio, que se actualize solo
                        //Agregar validaciones
                        Repartidor repartidor = new Repartidor(GenerarID(), nombre, numeroTelefono, licencia, disponibilidad, entregas, 0);
                        repartidores.Add(repartidor);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Repartidor agregado");
                        Console.ResetColor();
                        MenuRepartidor();
                        break;
                    case 2:
                        foreach (Repartidor objeto in repartidores)
                        {
                            objeto.MostrarInformacion();
                            Console.WriteLine();
                        }
                        Console.ReadKey();
                        MenuRepartidor();
                        break;
                    case 3:
                        int codigo;
                        do
                        {
                            Console.ResetColor();
                            foreach (Repartidor objeto in repartidores)
                            {
                                objeto.MostrarInformacion();
                                Console.WriteLine();
                            }
                            Console.WriteLine("Seleccione el codigo del repartidor:");
                            if (!int.TryParse(Console.ReadLine(), out codigo))
                            {
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("ingrese el codigo solo con numeros");
                            }
                            else { break; }
                        } while (true);
                        int posicion = repartidores.FindIndex(p => p.Codigo == codigo);
                        Console.WriteLine("Ingresa el Nuevo nombre:");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el nuevo numero de telefono:");
                        numeroTelefono = Console.ReadLine();
                        Console.WriteLine("Ingrese la nueva licencia:");
                        //validar entrada
                        licencia = char.Parse(Console.ReadLine());
                        //implementar las validaciones

                        repartidores[posicion].Nombre = nombre;
                        repartidores[posicion].NumeroTelefono = numeroTelefono;
                        repartidores[posicion].TipoLicencia = licencia;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Datos actualizados");
                        MenuRepartidor();
                        break;
                    case 4:
                        //nose agregar un metodo para cambiar la disponibilidad
                        Console.WriteLine("Se modigicara eso pronto...");
                        MenuRepartidor();
                        break;
                    case 5:
                        MenuPrincipal();
                        break;
                    default:
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Opcion invalida");
                        Console.ResetColor();
                        MenuRepartidor();
                        break;
                }
            }
            //programa
            MenuPrincipal();
        }
    }
}
