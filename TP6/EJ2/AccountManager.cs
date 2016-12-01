using EJ2.Domain;
using EJ2.DAL;
using EJ2.DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class AccountManager
    {

        private UnitOfWork CrearTransaccion()
        {
            try
            {
                return new UnitOfWork(new AccountManagerDbContext());
            }
            catch (Exception)
            {
                throw new ApplicationException("Error de conexion con la base de datos");
            }       
        }




        public void AgregarCliente(string pNombre, string pApellido, string pNroDocumento, String pTipoDocumento)
        {

            DocumentType tipoDocumento;

            switch (pTipoDocumento)
            {
                case "DNI":
                    {
                        tipoDocumento = DocumentType.DNI;
                        break;
                    }
                case "CUIL":
                    {
                        tipoDocumento = DocumentType.CUIL;
                        break;
                    }
                case "LC":
                    {
                        tipoDocumento = DocumentType.LC;
                        break;
                    }
                case "LE":
                    {
                        tipoDocumento = DocumentType.LE;
                        break;
                    }
                default:
                    throw new ArgumentException("No valido", nameof(pTipoDocumento));
            }

            Client cliente = new Client()
            {
                FirstName = pNombre,
                LastName = pApellido,
                Document = new Document()
                {
                    Number = pNroDocumento,
                    Type = tipoDocumento,
                }
            };

            UnitOfWork transaccion = this.CrearTransaccion();
            try
            {
                transaccion.ClientRepository.Add(cliente);
                transaccion.Complete();   
            }
            catch (Exception)
            {
                throw new ApplicationException("Se produjo un error al persistir los cambios");
            }
            finally
            {
                transaccion.Dispose();
            }

        }




        public void EliminarCliente(int clientId)
        {

            UnitOfWork transaccion = this.CrearTransaccion();
            try
            {
                
                Client client = transaccion.ClientRepository.Get(clientId);
                transaccion.ClientRepository.Remove(client);
                transaccion.Complete();
            }
            catch (Exception)
            {
                throw new ApplicationException("Se produjo un error al persistir los cambios");
            }

        }

    }
}
