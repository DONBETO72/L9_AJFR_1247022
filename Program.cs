class Program
{
    static void Main(string[] args)
    {
        Automovil objAutomovil = new Automovil(2019, 10000.00, "", false, 7.50, 0.00);


        Console.WriteLine("Ingrese la marca del automóvil:");
        objAutomovil.DefinirMarca(Console.ReadLine());

        Console.WriteLine("Ingrese el precio del automóvil:");
        objAutomovil.DefinirPrecio(double.Parse(Console.ReadLine()));

        Console.WriteLine("Ingrese el modelo del automóvil:");
        objAutomovil.DefinirModelo(int.Parse(Console.ReadLine()));

        Console.WriteLine("Ingrese el tipo de cambio de dolar:");
        objAutomovil.DefinirTipoCambioDolar(double.Parse(Console.ReadLine()));

        Console.WriteLine("Ingrese el la cantidad de descuento:");
        objAutomovil.DefinirDescuentoAplicado(double.Parse(Console.ReadLine()));

        Console.WriteLine(objAutomovil.MostrarInformacion());

        Console.ReadKey();
    }

}
        class Automovil
        {
           //atributos privados; 
            private int modelo;
            private double precio;
            private string marca;
            private bool disponible;
            private double tipoCambioDolar;
            private double descuentoAplicado;

            // métodos público
            public Automovil (int Modelo, double Precio, string Marca, bool Disponible, double TipoCambioDolar, double DescuentoAplicado)
            {
                modelo = Modelo;
                precio = Precio;
                marca = Marca; 
                disponible = Disponible;
                tipoCambioDolar = TipoCambioDolar;
                descuentoAplicado = DescuentoAplicado;  

            }    
            public void DefinirModelo(int unModelo)
            {
            modelo = unModelo;
            } 
        
            public void DefinirPrecio(double unPrecio)
            {
                precio = unPrecio;
            }
        
            public void DefinirMarca(string unaMarca) 
            {
            marca = unaMarca;
            }

            public void CambiarDisponible() 
            {
                if (disponible == true)
                {
                    disponible=false;
                }
                else
                {
                    disponible=true;
                }
            }

            public string MostrarDisponibilidad()
            {
                if (disponible==true)
                {
                return "Disponible";
                }
                else
                {
                return "No se encuentra disponible actualmente";
                }

            }   

            public void DefinirTipoCambioDolar(double unTipoCambioDolar)
            {
        tipoCambioDolar = unTipoCambioDolar;
            }

            public void DefinirDescuentoAplicado( double unDescuentoAplicado)
            {
                descuentoAplicado = unDescuentoAplicado;
            }
            
            public string MostrarInformacion()
            {
                return "Marca: " + marca+ ", precio: " + precio + ", modelo: " +modelo + ", el tipo de cambio de dolar es: " + tipoCambioDolar + ", el descuento aplicado es de :"+descuentoAplicado + ".";             
            }

                 
        }   