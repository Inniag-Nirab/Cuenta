namespace Cuenta
{
    public class Cuenta
    {
        private string numeroCuenta;
        private decimal saldo;

        public Cuenta(string numeroCuenta, decimal saldoInicial)
        {
            if (numeroCuenta.Length != 10)
            {
                throw new Exception("La longitud de la cuenta debe ser de 10 dígitos.");
            }

            this.numeroCuenta = numeroCuenta;
            this.saldo = saldoInicial;
        }

        public void Incrementar(decimal cantidad)
        {
            if (cantidad < 0)
            {
                throw new Exception("La cantidad a incrementar debe ser positiva.");
            }

            this.saldo += cantidad;
        }

        public void Decrementar(decimal cantidad)
        {
            if (cantidad < 0)
            {
                throw new Exception("La cantidad a decrementar debe ser positiva.");
            }

            if (this.saldo < cantidad)
            {
                throw new Exception("Saldo insuficiente.");
            }

            this.saldo -= cantidad;
        }

        public string ObtenerEstadoCuenta()
        {
            return this.saldo >= 0 ? "Activa" : "Inactiva";
        }

        public decimal ObtenerSaldo()
        {
            return this.saldo;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta miCuenta = new Cuenta("1234567890", 1000);
            Console.WriteLine("Saldo inicial: " + miCuenta.ObtenerSaldo());
            Console.WriteLine("Estado inicial de la cuenta: " + miCuenta.ObtenerEstadoCuenta());

            miCuenta.Incrementar(500);
            Console.WriteLine("Saldo después de incrementar: " + miCuenta.ObtenerSaldo());
            Console.WriteLine("Estado de la cuenta después de incrementar: " + miCuenta.ObtenerEstadoCuenta());

            miCuenta.Decrementar(1500);
            Console.WriteLine("Saldo después de decrementar: " + miCuenta.ObtenerSaldo());
            Console.WriteLine("Estado de la cuenta después de decrementar: " + miCuenta.ObtenerEstadoCuenta());
        }
    }
}


//En este código, se crea una nueva instancia de Cuenta en el método Main con un número de cuenta de “1234567890”
//y un saldo inicial de 1000. Luego, se incrementa el saldo en 500 y se decrementa en 1500.