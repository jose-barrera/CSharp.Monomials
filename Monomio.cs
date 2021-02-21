using System;

namespace Monomios
{
    class Monomio
    {
        // Variables internas
        private double coeficiente;
        private int exponente;

        // Constructores
        public Monomio()
        {
            this.coeficiente = 0;
            this.exponente = 0;
        }
        public Monomio(double coeficiente, int exponente)
        {
            // Validamos que el exponente no sea
            // negativo; de serlo, generamos un
            // error.
            if (exponente >= 0)
            {
                this.coeficiente = coeficiente;
                this.exponente = exponente;
            }
            else
            {
                throw new ArgumentException("El exponente debe ser un entero no negativo.");
            }
        }

        // Propiedades (solo lectura)
        public double Coeficiente
        {
            get
            {
                return this.coeficiente;
            }
        }
        public int Exponente
        {
            get
            {
                return this.exponente;
            }
        }

        // Métodos
        public Monomio Sumar(Monomio monomio)
        {
            // Para sumar monomios, los exponentes deben
            // ser iguales.
            if (this.exponente == monomio.exponente)
            {
                return new Monomio(this.coeficiente + monomio.coeficiente, this.exponente);
            }
            else
            {
                throw new Exception("SUMAR: Operación inválida.");
            }
        }
        public Monomio Restar(Monomio monomio)
        {
            // Para restar monomios, los exponentes deben
            // ser iguales.
            if (this.exponente == monomio.exponente)
            {
                return new Monomio(this.coeficiente - monomio.coeficiente, this.exponente);
            }
            else
            {
                throw new Exception("SUMAR: Operación inválida.");
            }
        }
        public Monomio Multiplicar(Monomio monomio)
        {
             return new Monomio(this.coeficiente * monomio.coeficiente, this.exponente + monomio.exponente);
        }
        public Monomio Dividir(Monomio divisor)
        {
            // Para dividir monomios, el coeficiente del divisor debe ser diferente
            // de cero y el exponente del dividendo debe ser mayor o igual al exponente
            // del divisor.
            if (divisor.coeficiente != 0 && this.exponente >= divisor.exponente)
            {
                return new Monomio(this.coeficiente / divisor.coeficiente, this.exponente - divisor.exponente);
            }
            else
            {
                throw new Exception("SUMAR: Operación inválida.");
            }
        }
        public double Evaluar(double valor)
        {
            return this.coeficiente * Math.Pow(valor, this.exponente);
        }
        public string Imprimir()
        {
            string resultado, signo, coeficiente, potencia;

            // El signo imprimible es "+" o "-" dependiendo
            // si el coeficiente es positivo o negativo.
            signo = this.coeficiente >= 0 ? "+ " : "- ";

            // El coeficiente imprimible es el valor absoluto
            // del coeficiente,
            coeficiente = Math.Abs(this.coeficiente).ToString();

            // Si el exponente es 0, la variable vale 1;
            // si el exponente es 1, solo se imprime la variable;
            // si el exponente es mayor que 1, se imprime la variable
            // y el exponente con el símbolo "^".
            if (this.exponente == 0)
            {
                potencia = "";
            }
            else if(this.exponente == 1)
            {
                potencia = " x";
            }
            else
            {
                potencia = " x^" + this.exponente;
            }

            // CASO ESPECIAL: El coeficiente es 0 por lo tanto
            // todo el monomio vale cero.
            if (this.coeficiente == 0)
            {
                resultado = "+ 0";
            }
            else
            {
                resultado = signo + coeficiente + potencia;
                // Verificamos el caso especial de 1x que se 
                // escribe sin el 1
                resultado = resultado.Replace("1 x", "x");
            }

            return resultado;
        }
    }
}
