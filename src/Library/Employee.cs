using System;

namespace Herencia {

    public class Employee : Person {

        public String address;
        public Int32 age;
        public String perID;

        public Employee (String name, String lastname, String mail, Int32 age, String perID) 
        : base (name, lastname, mail) {
            this.age = age;
            this.perID = perID;
        }

    }

}