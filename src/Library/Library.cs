using System;
using System.Collections;


    namespace Herencia {

        public class Library : IEnumerable  {
            private IList catalogue = new ArrayList ();
            private IList clients = new ArrayList ();
            private IList employees = new ArrayList ();

            public void AddCD (CD oCD) {
                this.catalogue.Add (oCD); //Se realiza encapsulación, ya que IList permite cualquier
                                          //tipo de objeto, por lo que se aplica esta restricción
            }
            public void AddClient (Client oClient) {
                this.clients.Add (oClient);
            }
            public void AddEmployee (Employee oEmployee) {
                this.employees.Add (oEmployee);
            }

            public IList GetCDByGenre (String genre) {
                IList result = new ArrayList ();

                foreach (CD oCD in this.catalogue) {
                    if (oCD.Genre.Equals (genre)) {
                        result.Add (oCD);
                    }
                }

                return result;
            }

               public IEnumerator GetEnumerator () {
                 return this.catalogue.GetEnumerator ();
            } 
        }
    }