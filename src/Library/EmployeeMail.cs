using System;

namespace Herencia {

    public class EmployeeMail : Mail {

        public Employee employee {get;}

        public EmployeeMail (Employee employee, String subjectM, String fromM) 
        : base(employee, subjectM, fromM)
        {
            this.employee = employee;
            this.Body = $"Estimado {this.employee.name} {this.employee.lastname}, nos comunicamos por este medio para comunicarle que desde el día 17 del corriente mes, usted trabajará en el área de productos. ¡Buen comienzo!";
        }

    }

}