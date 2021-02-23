using System;

namespace Monomials
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestMonomialStringRepresentation();

            Console.WriteLine("This program allows to perform basic arithmetic with two");
            Console.WriteLine("monomials, assuming that conditions are complied.");
            Console.WriteLine("");

            Console.WriteLine("*** MONOMIAL 1 ***");
            Console.Write("Write the coefficient 1: ");
            double c1 = Double.Parse(Console.ReadLine());
            Console.Write("Write the exponent 1: ");
            int e1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("");
            Monomial M1 = new Monomial(c1, e1);

            Console.WriteLine("*** MONOMIAL 2 ***");
            Console.Write("Write the coefficient 2: ");
            double c2 = Double.Parse(Console.ReadLine());
            Console.Write("Write the exponent 2: ");
            int e2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("");
            Monomial M2 = new Monomial(c2, e2);

            Monomial sum = null;
            Monomial difference = null;
            Monomial product = null;
            Monomial quotient = null;

            // Monomial addition: M1 + M2
            try
            {
                sum = M1.Add(M2);
                Console.WriteLine("SUM: " + sum.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("SUM: Invalid operation.");
            }
            // Monomial subtraction: M1 - M2
            try
            {
                difference = M1.Subtract(M2);
                Console.WriteLine("DIFFERENCE: " + difference.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("DIFFERENCE: Invalid operation.");
            }
            // Monomial multiplication: M1 * M2
            product = M1.Multiply(M2);
            Console.WriteLine("PRODUCT: " + product.ToString());
            // Monomial division: M1 / M2;
            try
            {
                quotient = M1.Divide(M2);
                Console.WriteLine("QUOTIENT: " + quotient.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("QUOTIENT: Invalid operation.");
            }
            Console.WriteLine();

            Console.Write("Write the value to evaluate: ");
            double value = Double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Value of M1 is " + M1.Evaluate(value));
            Console.WriteLine("Value of M2 is " + M2.Evaluate(value));
            if (sum != null)
            {
                Console.WriteLine("Value of M1 + M2 is " + sum.Evaluate(value));
            }
            else
            {
                Console.WriteLine("Value of M1 + M2 cannot be computed because is an invalid operation.");
            }
            if (difference != null)
            {
                Console.WriteLine("Value of M1 - M2 is " + difference.Evaluate(value));
            }
            else
            {
                Console.WriteLine("Value of M1 - M2 cannot be computed because is an invalid operation.");
            }
            Console.WriteLine("Value of M1 * M2 is " + product.Evaluate(value));
            if (quotient != null)
            {
                Console.WriteLine("Value of M1 / M2 is " + quotient.Evaluate(value));
            }
            else
            {
                Console.WriteLine("Value of M1 / M2 cannot be computed because is an invalid operation.");
            }

            Console.WriteLine("");
            Console.WriteLine("THANK YOU FOR USING THIS PROGRAM!");

            Console.ReadLine();
        }
        static void TestMonomialStringRepresentation()
        {
            Console.WriteLine(new Monomial(0, 0).ToString());
            Console.WriteLine(new Monomial(0, 1).ToString());
            Console.WriteLine(new Monomial(0, 5).ToString());
            Console.WriteLine(new Monomial(1, 0).ToString());
            Console.WriteLine(new Monomial(1, 1).ToString());
            Console.WriteLine(new Monomial(1, 5).ToString());
            Console.WriteLine(new Monomial(7.5, 0).ToString());
            Console.WriteLine(new Monomial(7.5, 1).ToString());
            Console.WriteLine(new Monomial(7.5, 5).ToString());
            Console.WriteLine(new Monomial(-0, 0).ToString());
            Console.WriteLine(new Monomial(-0, 1).ToString());
            Console.WriteLine(new Monomial(-0, 5).ToString());
            Console.WriteLine(new Monomial(-1, 0).ToString());
            Console.WriteLine(new Monomial(-1, 1).ToString());
            Console.WriteLine(new Monomial(-1, 5).ToString());
            Console.WriteLine(new Monomial(-7.5, 0).ToString());
            Console.WriteLine(new Monomial(-7.5, 1).ToString());
            Console.WriteLine(new Monomial(-7.5, 5).ToString());
            Console.WriteLine(new Monomial(91, 0).ToString());
            Console.WriteLine(new Monomial(91, 1).ToString());
            Console.WriteLine(new Monomial(91, 5).ToString());
        }
    }
}
