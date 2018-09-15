using System;

namespace Herencia {

    public class Mail {

        public String subjectM {get;}
        public String fromM {get;} 
        public Person toM {get;}
        public String Body {get; set;}
        public Mail (Person toM, String subjectM, String fromM) 
        {
            this.subjectM = subjectM;
            this.fromM = fromM;
            this.toM = toM;
        }

    }

}