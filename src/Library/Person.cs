using System;

namespace Herencia {

    public abstract class Person {
        public String name;

        public String lastname;

        public String mail;

        public Person (String name, String lastname, String mail) {
            this.name = name;
            this.lastname = lastname;
            this.mail = mail;

        }

    }
}