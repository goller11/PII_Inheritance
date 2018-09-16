using System;

namespace Herencia {

    class Program {

        /* Parte nº 1: la empresa GhostBuster desea mandar mails a sus clientes y empleados. 
        La implementación de MailSender fue producto de un código provisto por los profesores. */

        public static void Main (string[] args) {
                
        Employee guillermoE = new Employee ("Guillermo", "Vogel", "guillevogel11@gmail.com", 18, "50968735");
        Client guillermoC = new Client ("Guillermo", "Vogel", "guillevogel11@gmail.com", "Ciudad de la Costa");
            
        string mailFrom = ""; // Ingrese una dirección de correo
        string passwordFrom = ""; // Ingrese su contraseña

        /*Actualmente, el servicio configurado en MailSender.cs está hecho para mandar correos desde Gmail, en 
        caso de querer utilizar tal servicio desde otro cliente de correo, es necesario cambiar el SMTP, así 
        como también el Puerto asignado para cada correo. 
        
        En caso de querer cambiar a otro servicio de correo, en el archivo SMTP.txt, ubicado en la carpeta Library,
        se ubican las instrucciones para cambiar desde Gmail a Hotmail. 
        
        Para poder utilizar tal servicio en su correo, debe acceder a la configuración de su correo y permitir el 
        acceso de aplicaciones menos seguras. */

        EmployeeMail EmailingAnEmployee = new EmployeeMail(guillermoE, "Comunicado de puesto de trabajo", mailFrom);
        CustomerMail EmailingAClient = new CustomerMail(guillermoC,"Comunicado de venta de producto", mailFrom);

        MailSender mailS = new MailSender(mailFrom, passwordFrom);
            
        mailS.EnviarMail(mailFrom, "Recursos humanos - GhostBusters Enterprise", EmailingAnEmployee.toM.mail, EmailingAnEmployee.subjectM, EmailingAnEmployee.Body);         
        mailS.EnviarMail(mailFrom, "Área de productos - GhostBusters Enterprise", EmailingAClient.toM.mail, EmailingAClient.subjectM, EmailingAClient.Body);
        
        }

        // Parte nº 2
        // Agregado de CDs, clientes y empleados.
        private static Library disks = new Library ();
        private static Library clients = new Library ();
        private static Library employees = new Library ();

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
    