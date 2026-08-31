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

            private int cantidadPersonas;

            public int CantidadPersonas
            {
                get { return cantidadPersonas; }
                set { if (value > 0)
                    { cantidadPersonas = value; }
                }
            }

           
            public override void MostrarInformacion()
            {
                Console.WriteLine("Código: " + Codigo);
                Console.WriteLine("Nombre: " + Nombre);
                Console.WriteLine("Número de Teléfono: " + NumeroTelefono);
                Console.WriteLine("Correo Electrónico: " + CorreoElectronico);
                Console.WriteLine("Dirección: " + Direccion);
                Console.WriteLine("Cantidad de Personas: " + CantidadPersonas);
            }

            public Cliente(int codigo, string nombre, string numeroTelefono, string correoElectronico, string direccion, int cantidadPersonas)
               : base(codigo, nombre, numeroTelefono)
            {
                CorreoElectronico = correoElectronico;
                Direccion = direccion;
                CantidadPersonas = cantidadPersonas;
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
                Console.WriteLine("Código: " + Codigo);
                Console.WriteLine("Nombre: " + Nombre);
                Console.WriteLine("Número de Teléfono: " + NumeroTelefono);
                Console.WriteLine("Tipo de Licencia: " + TipoLicencia);
                Console.WriteLine("Cantidad de Entregas: " + CantidadEntregas);
                Console.WriteLine("Calificación: " + Calificacion);
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
            int opcion;
            void MenuPrincipal()
            {
                do
                {
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("============================================== XelaDriver ==============================================");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Seleccione una opcion: \n" +
                        "1. Gestion de Clientes" +
                        "2. Gestion de Repartidores \n" +
                        "3. Gestion de Vehiculos \n" +
                        "4. Gestion de Paquetes \n" +
                        "5. Gestion de Entregas \n" +
                        "6. Gestion de Incidencias \n" +
                        "7. Reportes \n" +
                        "8. Salir");

                    if(!int.TryParse(Console.ReadLine(), out opcion))
                    {
                        //buscar una forma mas optima de validar los datos
                        //hay que intentar con excepciones
                        Console.BackgroundColor= ConsoleColor.DarkRed;
                        Console.WriteLine("Ingrese su opcion en numeros enteros");
                    }
                    else { break; }
                } 
                while (true);

                switch(opcion)
                {
                    case 1: // gestion de clientes
                        break;
                    case 2: // gestion de repartidores
                        break;
                    case 3: // gestion de vehiculos
                        break;
                    case 4: // gestion de paquetes
                        break;
                    case 5: // gestion de entregas
                        break;
                    case 6: // gestion de incidencias
                        break;
                    case 7: // reportes
                        break; 
                    case 8: //bye perro
                        break;
                    default:
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Opcion Invalida");
                        break;
                }
            }

            List<Cliente> clientes = new List<Cliente>();
            List<Repartidor> repartidores = new List<Repartidor>();
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            List<Paquete> paquetes = new List<Paquete>();

            void MenuClientes()
            {
                do
                {
                    Console.ResetColor();
                    Console.WriteLine(@"======== Menu clientes ========
Seleccione una opcion: 
1. Registrar nuevo cliente 
2. Consultar lista de clientes 
3. Actualizar cliente existente 
4. Regresar");
                    do
                    {
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
                            break;
                        case 2:
                            break;
                        case 3:
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
                            break;
                    }

                } while (opcion != 4);

            }
            MenuClientes();
        }
    }
}
