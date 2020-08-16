using System.Globalization;
namespace Course
{
    class BankAccount
    {
        public int BankNumber { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }
        public double TaxaSaque { get; private set; } = 5.00;

        public BankAccount(string titular,int numero)
        {
            this.BankNumber = numero;
            this.Titular = titular;
        }
        public BankAccount(string titular, int numero,double saldo) :this(titular,numero)
        {
            this.Saldo = saldo;
        }

        public void Deposito(double value)
        {
            this.Saldo += value;
        }

        public void Saque(double valor)
        {
            this.Saldo -= valor + this.TaxaSaque;
        }

        public override string ToString()
        {
            return "Conta: " +
                this.BankNumber +
                ", Titular: " +
                this.Titular +
                ", Saldo: $ " +
                this.Saldo.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
