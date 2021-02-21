using System;

namespace Monomios
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProbarImpresionMonomios();

            Console.WriteLine("Este programa te permite realizar operaciones aritméticas");
            Console.WriteLine("básicas con 2 monomios, siempre que se cumplan las condiciones");
            Console.WriteLine("para estas operaciones.");
            Console.WriteLine("");

            Console.WriteLine("*** MONOMIO 1 ***");
            Console.Write("Dime el coeficiente 1: ");
            double c1 = Double.Parse(Console.ReadLine());
            Console.Write("Dime el exponente 1: ");
            int e1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("");
            Monomio M1 = new Monomio(c1, e1);

            Console.WriteLine("*** MONOMIO 2 ***");
            Console.Write("Dime el coeficiente 2: ");
            double c2 = Double.Parse(Console.ReadLine());
            Console.Write("Dime el exponente 2: ");
            int e2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("");
            Monomio M2 = new Monomio(c2, e2);

            Monomio suma = null;
            Monomio resta = null;
            Monomio producto = null;
            Monomio cociente = null;

            // Suma de monomios: M1 + M2
            try
            {
                suma = M1.Sumar(M2);
                Console.WriteLine("SUMA: " + suma.Imprimir());
            }
            catch (Exception e)
            {
                Console.WriteLine("SUMA: Operación inválida.");
            }
            // Resta de monomios: M1 - M2
            try
            {
                resta = M1.Restar(M2);
                Console.WriteLine("RESTA: " + resta.Imprimir());
            }
            catch (Exception e)
            {
                Console.WriteLine("RESTA: Operación inválida.");
            }
            // Multiplicación de monomios: M1 * M2
            producto = M1.Multiplicar(M2);
            Console.WriteLine("PRODUCTO: " + producto.Imprimir());
            // División de monomios: M1 / M2;
            try
            {
                cociente = M1.Dividir(M2);
                Console.WriteLine("COCIENTE: " + cociente.Imprimir());
            }
            catch (Exception e)
            {
                Console.WriteLine("COCIENTE: Operación inválida.");
            }
            Console.WriteLine();

            Console.Write("Dime el valor para evaluar: ");
            double valor = Double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("El valor del M1 es " + M1.Evaluar(valor));
            Console.WriteLine("El valor del M2 es " + M2.Evaluar(valor));
            if (suma != null)
            {
                Console.WriteLine("El valor de M1 + M2 es " + suma.Evaluar(valor));
            }
            else
            {
                Console.WriteLine("El valor de M1 + M2 es operación inválida.");
            }
            if (resta != null)
            {
                Console.WriteLine("El valor de M1 - M2 es " + resta.Evaluar(valor));
            }
            else
            {
                Console.WriteLine("El valor de M1 - M2 es operación inválida.");
            }
            Console.WriteLine("El valor de M1 * M2 es " + producto.Evaluar(valor));
            if (cociente != null)
            {
                Console.WriteLine("El valor de M1 / M2 es " + cociente.Evaluar(valor));
            }
            else
            {
                Console.WriteLine("El valor de M1 / M2 es operación inválida.");
            }

            Console.WriteLine("");
            Console.WriteLine("¡MUCHAS GRACIAS POR USAR ESTE PROGRAMA!");

            Console.ReadLine();
        }
        static void ProbarImpresionMonomios()
        {
            Console.WriteLine(new Monomio(0, 0).Imprimir());
            Console.WriteLine(new Monomio(0, 1).Imprimir());
            Console.WriteLine(new Monomio(0, 5).Imprimir());
            Console.WriteLine(new Monomio(1, 0).Imprimir());
            Console.WriteLine(new Monomio(1, 1).Imprimir());
            Console.WriteLine(new Monomio(1, 5).Imprimir());
            Console.WriteLine(new Monomio(7.5, 0).Imprimir());
            Console.WriteLine(new Monomio(7.5, 1).Imprimir());
            Console.WriteLine(new Monomio(7.5, 5).Imprimir());
            Console.WriteLine(new Monomio(-0, 0).Imprimir());
            Console.WriteLine(new Monomio(-0, 1).Imprimir());
            Console.WriteLine(new Monomio(-0, 5).Imprimir());
            Console.WriteLine(new Monomio(-1, 0).Imprimir());
            Console.WriteLine(new Monomio(-1, 1).Imprimir());
            Console.WriteLine(new Monomio(-1, 5).Imprimir());
            Console.WriteLine(new Monomio(-7.5, 0).Imprimir());
            Console.WriteLine(new Monomio(-7.5, 1).Imprimir());
            Console.WriteLine(new Monomio(-7.5, 5).Imprimir());
        }
    }
}
