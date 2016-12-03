using EJ2.Domain;
using EJ2.DAL;
using EJ2.DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EJ2.DTO;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;

namespace EJ2
{
    /// <summary>
    /// Fachada de controlador de las cuentas.
    /// </summary>
    public class AccountManager
    {
        /// <summary>
        /// Crea una transaccion en el contexto de la base de datos.
        /// </summary>
        /// <returns>Transaccion</returns>
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



        //ADMINISTRACION DE CLIENTES//

        /// <summary>
        /// Agrega un cliente a la base de datos.
        /// </summary>
        /// <param name="pClientDTO">Cliente en forma DTO</param>
        public void AgregarCliente(ClientDTO pClientDTO)
        {
            Client cliente = AutoMapper.Mapper.Map<Client>(pClientDTO);

            UnitOfWork transaccion = this.CrearTransaccion();
            try
            {
                transaccion.ClientRepository.Add(cliente);
                transaccion.Complete();
            }
            catch (DbUpdateException)
            {
                throw new InvalidOperationException("El cliente ya existe");
            }
            catch(DbEntityValidationException)
            {
                throw new ArgumentException("Datos no validos");
            }
            finally
            {
                transaccion.Dispose();
            }

        }

        /// <summary>
        /// Modifica un cliente de la base de datos.
        /// </summary>
        /// <param name="pClientDTO">Cliente en forma DTO</param>
        public void ModificarCliente(ClientDTO pClientDTO)
        {

            Client clientAct = AutoMapper.Mapper.Map<Client>(pClientDTO);


            UnitOfWork transaccion = this.CrearTransaccion();

            Client client = transaccion.ClientRepository.Get(clientAct.Id);

            if (client == null)
            {
                transaccion.Dispose();
                throw new InvalidOperationException("El cliente no existe");
            }

            client.Document = clientAct.Document;
            client.FirstName = clientAct.FirstName;
            client.LastName = clientAct.LastName;

            try
            {
                transaccion.Complete();
            }
            catch (DbEntityValidationException)
            {
                throw new ArgumentException("Datos no validos");
            }
            finally
            {
                transaccion.Dispose();
            }
            

        }


        /// <summary>
        /// Elimina un cliente de la base de datos.
        /// </summary>
        /// <param name="clientId">Cliente en forma DTO</param>
        public void EliminarCliente(int clientId)
        {

            UnitOfWork transaccion = this.CrearTransaccion();
                
            Client client = transaccion.ClientRepository.Get(clientId);

            if (client == null)
            {
                transaccion.Dispose();
                throw new InvalidOperationException("El cliente no existe");
            }

            transaccion.ClientRepository.Remove(client);
            transaccion.Complete();
            transaccion.Dispose();
        }

        /// <summary>
        /// Obtiene un cliente de la base de datos.
        /// </summary>
        /// <param name="clientId">Id del cliente</param>
        /// <returns>Cliente en forma DTO</returns>
        public ClientDTO ObtenerCliente(int clientId)
        {

            UnitOfWork transaccion = this.CrearTransaccion();
            ClientDTO client;

            client = AutoMapper.Mapper.Instance.Map<ClientDTO>(transaccion.ClientRepository.Get(clientId));
                transaccion.Complete();

            transaccion.Dispose();

            if(client==null)
                throw new InvalidOperationException("El cliente no existe");

            return client;
        }

        /// <summary>
        /// Obtiene la lista de todos los clientes que se encuentran en la base de datos.
        /// </summary>
        /// <returns>Enumerable de todos los clientes en forma DTO</returns>
        public IEnumerable<ClientDTO> ListaClientes()
        {
            UnitOfWork transaccion = this.CrearTransaccion();
            IEnumerable<ClientDTO> list;

            list = AutoMapper.Mapper.Map<IEnumerable<ClientDTO>>(transaccion.ClientRepository.GetAll());
            transaccion.Complete();
            transaccion.Dispose();

            return list;
        }





        //ADMINISTRACION DE CUENTAS//

        /// <summary>
        /// Agrega una cuenta a la base de datos.
        /// </summary>
        /// <param name="pAccountDTO">Cuenta en forma DTO</param>
        public void AgregarCuenta(AccountDTO pAccountDTO)
        {
            Account cuenta = AutoMapper.Mapper.Map<Account>(pAccountDTO);

            UnitOfWork transaccion = this.CrearTransaccion();
            try
            {
                cuenta.Client = transaccion.ClientRepository.Get(cuenta.Client.Id);
                transaccion.AccountRepository.Add(cuenta);
                transaccion.Complete();
            }
            catch (DbUpdateException)
            {
                throw new InvalidOperationException("El cliente no existe");
            }
            catch (DbEntityValidationException)
            {
                throw new ArgumentException("Datos no validos");
            }
            finally
            {
                transaccion.Dispose();
            }

        }

        /// <summary>
        /// Modifica una cuenta en la base de datos.
        /// </summary>
        /// <param name="pCuentaDTO">Cuenta en forma DTO</param>
        public void ModificarCuenta(AccountDTO pCuentaDTO)
        {

            Account cuentaAct = AutoMapper.Mapper.Map<Account>(pCuentaDTO);


            UnitOfWork transaccion = this.CrearTransaccion();

            Account cuenta = transaccion.AccountRepository.Get(cuentaAct.Id);

            if (cuenta == null)
            {
                transaccion.Dispose();
                throw new InvalidOperationException("La cuenta no existe");
            }

            Client cliente = transaccion.ClientRepository.Get(cuentaAct.Client.Id);
            if (cliente == null)
            {
                throw new ArgumentException("Datos no validos");
            }
            cuenta.Client = cliente;

            cuenta.Name = cuentaAct.Name;
            cuenta.OverdraftLimit = cuentaAct.OverdraftLimit;

            try
            {
                transaccion.Complete();
            }
            catch (DbEntityValidationException)
            {
                throw new ArgumentException("Datos no validos");
            }
            finally
            {
                transaccion.Dispose();
            }


        }

        /// <summary>
        /// Elimina una cuenta de la base de datos.
        /// </summary>
        /// <param name="cuentaId">Id de la cuenta</param>
        public void EliminarCuenta(int cuentaId)
        {

            UnitOfWork transaccion = this.CrearTransaccion();

            Account cuenta = transaccion.AccountRepository.Get(cuentaId);

            if (cuenta == null)
            {
                transaccion.Dispose();
                throw new InvalidOperationException("La cuenta no existe");
            }

            transaccion.AccountRepository.Remove(cuenta);
            transaccion.Complete();
            transaccion.Dispose();
        }

        /// <summary>
        /// Obtiene una cuenta de la base de datos.
        /// </summary>
        /// <param name="cuentaId">Id de la cuenta</param>
        /// <returns>Cuenta en forma DTO</returns>
        public AccountDTO ObtenerCuenta(int cuentaId)
        {

            UnitOfWork transaccion = this.CrearTransaccion();
            AccountDTO cuenta;

            cuenta = AutoMapper.Mapper.Instance.Map<AccountDTO>(transaccion.AccountRepository.Get(cuentaId));
            transaccion.Complete();

            transaccion.Dispose();

            if (cuenta == null)
                throw new InvalidOperationException("La cuenta no existe");

            return cuenta;
        }

        /// <summary>
        /// Obtiene una lista de todas las cuentas de la base de datos.
        /// </summary>
        /// <returns>Enumerable con todas las cuentas en formato DTO</returns>
        public IEnumerable<AccountDTO> ListaCuentas()
        {
            UnitOfWork transaccion = this.CrearTransaccion();
            IEnumerable<AccountDTO> list;

            list = AutoMapper.Mapper.Map<IEnumerable<AccountDTO>>(transaccion.AccountRepository.GetAll());
            transaccion.Complete();
            transaccion.Dispose();

            return list;
        }

        /// <summary>
        /// Obtiene el balance de una cuenta.
        /// </summary>
        /// <param name="cuentaId">Id de la cuenta</param>
        /// <returns>Balance</returns>
        public double ObtenerBalance(int cuentaId)
        {
            UnitOfWork transaccion = this.CrearTransaccion();
            Account cuenta = transaccion.AccountRepository.Get(cuentaId);

            if (cuenta == null)
            {
                transaccion.Dispose();
                throw new InvalidOperationException("La cuenta no existe");
            }

            double balance = transaccion.AccountRepository.GetAccountBalance(AutoMapper.Mapper.Map<Account>(cuenta));

            transaccion.Complete();

            transaccion.Dispose();

            return balance;
        }

        /// <summary>
        /// Obtiene las cuentas que superan el descubierto. 
        /// </summary>
        /// <returns>Lista de cuentas en forma DTO que superan el descubierto.</returns>
        public IEnumerable<AccountDTO> ObtenerCuentasSuperanDescubierto()
        {

            UnitOfWork transaccion = this.CrearTransaccion();
            IEnumerable<AccountDTO> listaCuentasDeudoras = AutoMapper.Mapper.Map<IEnumerable<AccountDTO>>(transaccion.AccountRepository.GetOverdrawnAccounts());

            transaccion.Complete();

            transaccion.Dispose();

            return listaCuentasDeudoras;
        }


        //ADMINISTRACION DE MOVIMIENTOS//

        /// <summary>
        /// Agrega un movimiento a una cuenta
        /// </summary>
        /// <param name="pCuentaId">Id de la cuenta</param>
        /// <param name="pMonto">Monto a transferir</param>
        /// <param name="pDescripcion">Descripcion de la transaccion</param>
        public void AgregarMovimiento(int pCuentaId,double pMonto,string pDescripcion)
        {
            if (pMonto == 0)
            {
                throw new ArgumentException("El monto no puede ser 0");
            }

            UnitOfWork transaccion = this.CrearTransaccion();
            Account cuenta = transaccion.AccountRepository.Get(pCuentaId);


            if (cuenta == null)
            {
                transaccion.Dispose();
                throw new InvalidOperationException("La cuenta no existe");
            }


            AccountMovement movimiento = new AccountMovement();
            movimiento.Amount = pMonto;
            movimiento.Date = DateTime.Now;
            movimiento.Description = pDescripcion;

            cuenta.Movements.Add(movimiento);

            transaccion.Complete();

            transaccion.Dispose();

        }

        /// <summary>
        /// Obtiene los n ultimos movimientos de una cuenta
        /// </summary>
        /// <param name="cuentaId">Id de la cuenta</param>
        /// <param name="nMovimientos">Cantidad de los ultimos movimientos a mostrar</param>
        /// <returns>Lista con los n movimientos de la cuenta en formato DTO</returns>
        public IEnumerable<AccountMovementDTO> ObtenerNMovimientos(int cuentaId,int nMovimientos)
        {
            if (nMovimientos <= 0)
            {
                throw new ArgumentException("la cantidad debe ser mayor a 0");
            }
            UnitOfWork transaccion = this.CrearTransaccion();
            Account cuenta = transaccion.AccountRepository.Get(cuentaId);

            if (cuenta == null)
            {
                transaccion.Dispose();
                throw new InvalidOperationException("La cuenta no existe");
            }

            IEnumerable<AccountMovementDTO> listaNMovimientos = AutoMapper.Mapper.Map< IEnumerable < AccountMovementDTO >>( transaccion.AccountRepository.GetLastMovements(cuenta,nMovimientos));

            transaccion.Complete();

            transaccion.Dispose();

            return listaNMovimientos;
        }

    }
}
