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

                db.Personas.Add(mPersona);
                db.SaveChanges();

                foreach (var per in db.Personas)
                {
                  Console.WriteLine("Persona encontrada - Nombre: {0}, Apellido: {1}, IdPersona: {2}", per.Nombre, per.Apellido, per.PersonaId);
                }

                Console.ReadKey();
            }
        }
    }
}
