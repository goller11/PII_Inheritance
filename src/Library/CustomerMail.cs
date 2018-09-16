using System;

namespace Herencia {

    public class CustomerMail : Mail {

        public Client Customer {get;}

        public CustomerMail (Client customer, String subjectM, String fromM) 
        : base(customer, subjectM, fromM)
        {
            this.Customer = customer;
            this.Body = $"Estimado {this.Customer.name}, lamentamos informarte que a partir del 17 del corriente mes vendrán nuevos productos a nuestros locales. ¡Lo esperamos en nuestra tienda en 8 de Octubre!";
        }

    }

}