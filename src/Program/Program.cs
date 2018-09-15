using System;

namespace Herencia {
    class Program {

        public static void Main (string[] args) {

                Console.Write("Correo desde donde desea mandar el mail: ");
                string MailSender = Console.ReadLine();
                Console.Write("Escriba su contraseña: ");
                string MailPassword = Console.ReadLine();


            Employee guillermoE = new Employee ("Guillermo", "Vogel", "guillevogel11@gmail.com", 18, "50968735");
            Client guillermoC = new Client ("Guillermo", "Vogel", "guillevogel11@gmail.com","Ciudad de la Costa");

            EmployeeMail EmailingAnEmployee = new EmployeeMail(guillermoE, "Comunicado de desvinculación", MailSender);
            CustomerMail EmailingAClient = new CustomerMail(guillermoC,"Comunicado de venta de producto", MailSender);


            MailSender mailS = new MailSender(MailSender, MailPassword);
            
            mailS.EnviarMail(MailSender, "Tomás Orín de la Fuente (Recursos humanos)", EmailingAnEmployee.toM.mail, EmailingAnEmployee.subjectM, EmailingAnEmployee.Body);         
            mailS.EnviarMail(MailSender, "Tomás Orín de la Fuente (Responsable de Producto)", EmailingAClient.toM.mail, EmailingAClient.subjectM, EmailingAClient.Body);
        
            }
                private static Library disks = new Library ();
                private static Library clients = new Library ();
                private static Library employees = new Library ();

            //
            private static void InitializeCDs () 
            {
            disks.AddCD (
                    new CD ("Powerslave", "Heavy metal", 1984, "Iron Maiden", new String[] { "Aces High", "2 minutes to Midnight", "Losfer Words" })); 
            disks.AddCD(
                    new CD ("Muerto pero Vivo", "Rock", 2016, "Cuatro Pesos de Propina", new String[] { "Solari", "Mi Revolución", "Glu Glu" }));        
            }

            private static void InitializeClients ()
            {
            clients.AddClient(
                    new Client ("Pablo", "Luchinetti", "pluchinetti@live.com", "Montevideo"));
            }

            private static void InitializeEmployees ()
            {
            clients.AddEmployee(
                    new Employee ("Pablo", "Luchinetti", "pluchinetti@live.com", 25, "47405029"));
            }

        }
    }
    