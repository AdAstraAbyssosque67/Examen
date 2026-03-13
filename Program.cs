using System;

namespace ExamenPractico
{
    internal class Program
    {
        public class Producto
        {
            public string Nombre { get; set; }
            public int Codigo { get; set; }
            public double Precio { get; set; }
            public int Cantidad { get; set; }

            public Producto(string nombre, int codigo, double precio, int cantidad)
            {
                Nombre = nombre;
                Codigo = codigo;
                Precio = precio;
                Cantidad = cantidad;
            }

            public virtual void MostrarProducto()
            {
                Console.WriteLine($"Nombre: {Nombre}\nCodigo: {Codigo}\nPrecio: {Precio}\nCantidad: {Cantidad}");
            }
            public virtual void CalcularImpuesto() { }
        }

        public class ProductoElectrico : Producto
        {
            public int GarantiaMeses { get; set; }
            public ProductoElectrico(string n, int c, double p, int cant, int g) : base(n, c, p, cant)
            {
                GarantiaMeses = g;
            }

            public override void CalcularImpuesto()
            {
                Console.WriteLine($"El Impuesto (18%) es: {Precio * 0.18}");
            }
        }

        public class ProductoAlimenticio : Producto
        {
            public string FechaVencimiento { get; set; }

            public ProductoAlimenticio(string n, int c, double p, int cant, string f) : base(n, c, p, cant)
            {
                FechaVencimiento = f;
            }

            public override void CalcularImpuesto()
            {
                Console.WriteLine($"El Impuesto (8%) es: {Precio * 0.08}");
            }
        }

        static void Main(string[] args)
        {
            ProductoElectrico A = new ProductoElectrico("PC", 101, 25000, 5, 12);
            ProductoAlimenticio B = new ProductoAlimenticio("Leche", 202, 50, 10, "20/12/2026");

            Console.WriteLine("Producto Electrico");
            A.MostrarProducto();
            A.CalcularImpuesto();
            Console.WriteLine();
            Console.WriteLine("Producto Alimenticio");
            B.MostrarProducto();
            B.CalcularImpuesto();
        }
    }
}


