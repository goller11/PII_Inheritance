using System;

namespace Herencia {

    public class EmployeeMail : Mail {

        public Employee employee {get;}

        public EmployeeMail (Employee employee, String subjectM, String fromM) 
        : base(employee, subjectM, fromM)
        {
            this.employee = employee;
            this.Body = $"Estimado {this.employee.name} {this.employee.lastname}, lamentamos informarte que a partir del 17 del corriente mes ya no formarás parte de la empresa. Tampoco cobrarás nada.";
        }

    }

}