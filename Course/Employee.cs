using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class Employee
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get; private set; }

        public Employee(int id, string nome, double salario)
        {
            this.Id = id;
            this.Nome = nome;
            this.Salario = salario;
        }

        public void AumentaSalario(double percent)
        {
            double temp = this.Salario * (percent / 100);
            this.Salario += temp;
        }

        public override string ToString()
        {
            return this.Id +
                ", " +
                this.Nome +
                ", " +
                this.Salario.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
