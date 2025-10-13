using System;

namespace Laboratorio8_2
{
    class Cuenta
    {
        public decimal Saldo { get; protected set; }

        public Cuenta(decimal saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public virtual decimal CalcularInteres()
        {
            return Saldo * 0.01m;
        }

        public virtual void Mostrar()
        {
            Console.WriteLine($"Saldo: {Saldo}, Interés: {CalcularInteres():C}");
        }
    }

    class CuentaAhorro : Cuenta
    {
        public CuentaAhorro(decimal saldo) : base(saldo) { }
        public override decimal CalcularInteres() => Saldo * 0.03m;
    }

    class CuentaPlazo : Cuenta
    {
        public int Meses { get; }
        public CuentaPlazo(decimal saldo, int meses) : base(saldo) => Meses = meses;
        public override decimal CalcularInteres() => Saldo * (0.05m + 0.001m * Meses);
    }

    class Program
    {
        static void Main()
        {
            Cuenta[] cuentas = {
                new Cuenta(1000),
                new CuentaAhorro(2000),
                new CuentaPlazo(5000, 12)
            };

            foreach (var c in cuentas)
            {
                c.Mostrar();
            }

            Console.ReadKey();
        }
    }
}