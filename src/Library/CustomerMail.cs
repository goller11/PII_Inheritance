using System;

namespace Herencia {

    public class CustomerMail : Mail {

        public Client Customer {get;}

        public CustomerMail (Client customer, String subjectM, String fromM) 
        : base(customer, subjectM, fromM)
        {
            this.Customer = customer;
            this.Body = $"Estimado {this.Customer.name}, lamentamos informarte que a partir del 17 del corriente mes se dejarán de vender los maníes japoneses en la cantina. Las unidades restantes se quemarán el domingo 16/09.";
        }

    }

}