using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1_
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AgendaContext())
            {
                //Se crea y modifica una persona, con su respectivo numero de telefono.
                Persona mPersona = new Persona
                {
                    PersonaId = 1,
                    Nombre = "Juan",
                    Apellido = "Perez",
                    Telefonos = new List<Telefono>
                    {
                        new Telefono
                        {
                            TelefonoId=1,
                            Numero="589102",
                            Tipo="Celular"
                        }
                    }
                };

                //Se agrega dicha persona a la base de datos.
                db.Personas.Add(mPersona);

                //Se guardan los cambios en la base de datos.
                db.SaveChanges();

                //Se muestran las personas encontradas.
                foreach (var per in db.Personas)
                {
                  Console.WriteLine("Persona encontrada - Nombre: {0}, Apellido: {1}, IdPersona: {2}", per.Nombre, per.Apellido, per.PersonaId);
                }

                Console.ReadKey();
            }
        }
    }
}
