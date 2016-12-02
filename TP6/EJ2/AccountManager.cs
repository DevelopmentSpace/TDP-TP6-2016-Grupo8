using EJ2.Domain;
using EJ2.DAL;
using EJ2.DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EJ2.DTO;

namespace EJ2
{
    public class AccountManager
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



        public void AgregarCliente(ClientDTO clientDTO)
        {
            Client cliente = AutoMapper.Mapper.Map<Client>(clientDTO);

            UnitOfWork transaccion = this.CrearTransaccion();
            try
            {
                transaccion.ClientRepository.Add(cliente);
                transaccion.Complete();
            }
            catch (Exception)
            {
                throw new ApplicationException("Se produjo un error en la base de datos.");
            }
            finally
            {
                transaccion.Dispose();
            }

        }


        /*
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
                throw new ApplicationException("Se produjo un error en la base de datos.");
            }
            finally
            {
                transaccion.Dispose();
            }

        }
        */



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
                throw new ApplicationException("Se produjo un error en la base de datos.");
            }
            finally
            {
                transaccion.Dispose();
            }

        }


        public ClientDTO ObtenerCliente(int clientId)
        {

            UnitOfWork transaccion = this.CrearTransaccion();
            Client client;
            try
            {

                client = transaccion.ClientRepository.Get(clientId);
                transaccion.Complete();
            }
            catch (Exception)
            {
                throw new ApplicationException("Se produjo un error en la base de datos.");
            }
            finally
            {
                transaccion.Dispose();
            }

            AutoMapper.Mapper.Initialize(cfg => cfg.CreateMap<Client, ClientDTO>());
            return AutoMapper.Mapper.Instance.Map<ClientDTO>(client);

        }


        public IEnumerable<ClientDTO> ListaClientes()
        {
            UnitOfWork transaccion = this.CrearTransaccion();
            IEnumerable<Client> list;

            try
            {
                list = transaccion.ClientRepository.GetAll();
                transaccion.Complete();
            }
            catch (Exception)
            {
                throw new ApplicationException("Se produjo un error en la base de datos.");
            }
            finally
            {
                transaccion.Dispose();
            }


            return AutoMapper.Mapper.Map<IEnumerable<ClientDTO>>(list);
        }

    }
}
