using System;

namespace Herencia {

    public class Client : Person {

        private String address;

        public Client (String name, String lastname, String mail, String address) 
            : base(name, lastname, mail) 
            {
                this.address = address;
            }
        

    }

}