using System;

namespace ExamenPractico
{
    internal class Program
    {
        public class Producto
        {
            private string nombre;
            private int codigo;
            private double precio;
            private int cantidad;

            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }

            public int Codigo
            {
                get { return codigo; }
                set { codigo = value; }
            }

            public double Precio
            {
                get { return precio; }
                set { precio = value; }
            }

            public int Cantidad
            {
                get { return cantidad; }
                set { cantidad = value; }
            }

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
            private int garantiaMeses;

            public int GarantiaMeses
            {
                get { return garantiaMeses; }
                set { garantiaMeses = value; }
            }

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
            private string fechaVencimiento;

            public string FechaVencimiento
            {
                get { return fechaVencimiento; }
                set { fechaVencimiento = value; }
            }

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

