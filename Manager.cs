using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Manager : Employee
    {
        public Manager()
        {
           
            PaymentMethod = new CreditCardPayment();
        }
    }
}
