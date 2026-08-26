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
                set { codigo = value; }
            }

            private string nombre;

            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }

            private string numeroTelefono;

            public string NumeroTelefono
            {
                get { return numeroTelefono; }
                set { numeroTelefono = value; }
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
                set { correoElectronico = value; }
            }

            private string direccion;

            public string Direccion
            {
                get { return direccion; }
                set { direccion = value; }
            }

            private int cantidadPersonas;

            public int CantidadPersonas
            {
                get { return cantidadPersonas; }
                set { cantidadPersonas = value; }
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
                set { cantidadEntregas = value; }
            }

            private double calificacion;

            public double Calificacion
            {
                get { return calificacion; }
                set { calificacion = value; }
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
                set { codigo = value; }
            }

            private Cliente propietario;

            
            public Cliente Propietario
            {
                
                get {
                    // sepa la bola que hay que hacer hay que arreglar esta mamada
                    return propietario; }
                set { propietario = value; }
            }

            private string descripcion;

            public string Descripcion
            {
                get { return descripcion; }
                set { descripcion = value; }
            }

            private double peso;

            public double Peso
            {
                get { return  peso; }
                set {  peso = value; }
            }

            private double valorDeclarado;

            public double ValorDeclarado
            {
                get { return  valorDeclarado; }
                set {  valorDeclarado = value; }
            }

            private string direccionOrigen;

            public string DireccionOrigen
            {
                get { return direccionOrigen; }
                set { direccionOrigen = value; }
            }

            private string direccionDestino;

            public string DireccionDestino
            {
                get { return direccionDestino; }
                set { direccionDestino = value; }
            }

            public virtual void CalcularDistancia(string Origen, string Destino)
            {
                // no sabemos ni vrga
            
            }

            public virtual void CalcularTarifa (double Peso, double Valor)
            { // no vrg
            }

           
            
        }

        class Documento : Paquete
        {
            public override void CalcularDistancia(string Origen, string Destino)
            {
                // no sabemos ni vrga

            }
            public override void CalcularTarifa(double Peso, double Valor)
            { // no vrg
            }
           

        }

        class Estandar : Paquete
        {
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
                set { placa = value; }
            }

            private string  marca;

            public string  Marca
            {
                get { return marca; }
                set { marca = value; }
            }

            private string modelo;

            public string Modelo
            {
                get { return modelo; }
                set { modelo = value; }
            }

            private double  capacidadCarga;

            public double  CapacidadCarga
            {
                get { return capacidadCarga; }
                set { capacidadCarga = value; }
            }

           public enum estadoVehiculo
            {Disponible, Asignado, Mantenimiento }

            private estadoVehiculo estado;

            public estadoVehiculo Estado
            {
                get { return estado; }
                set { estado = value; }
            }

            private double costo;

            public double Costo
            {
                get { return costo; }
                set { costo = value; }
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
        }
        
        class Bicicleta : Vehiculo
        {
            public override void MostrarInformacion()
            {
                Console.WriteLine("Placa: " + Placa);
                Console.WriteLine("Marca: " + Marca);
                Console.WriteLine("Modelo: " + Modelo);
                Console.WriteLine("Capacidad de Carga: " + CapacidadCarga);
                Console.WriteLine("Estado: " + Estado);
                Console.WriteLine("Costo: " + Costo);
            }
            public override void CalcularPrecio()
            { }
        }

        class Motocicleta : Vehiculo
        {
            public override void MostrarInformacion()
            {
                Console.WriteLine("Placa: " + Placa);
                Console.WriteLine("Marca: " + Marca);
                Console.WriteLine("Modelo: " + Modelo);
                Console.WriteLine("Capacidad de Carga: " + CapacidadCarga);
                Console.WriteLine("Estado: " + Estado);
                Console.WriteLine("Costo: " + Costo);
            }
            public override void CalcularPrecio()
            { }
        }

        class Automovil : Vehiculo
        {
            public override void MostrarInformacion()
            {
                Console.WriteLine("Placa: " + Placa);
                Console.WriteLine("Marca: " + Marca);
                Console.WriteLine("Modelo: " + Modelo);
                Console.WriteLine("Capacidad de Carga: " + CapacidadCarga);
                Console.WriteLine("Estado: " + Estado);
                Console.WriteLine("Costo: " + Costo);
            }
            public override void CalcularPrecio()
            { }
        }

        static void Main(string[] args)
        {
        }
    }
}
