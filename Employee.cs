using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public abstract class Employee
    {
        public string name;
        public IPaymentMethod PaymentMethod { get; set; }

        public Employee(string name)
        {
            this.name = name;
        }

        public void Pay(float amount)
        {
            PaymentMethod.Pay();
        }

    }
}
