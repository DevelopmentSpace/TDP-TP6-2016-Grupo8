﻿using EJ2.Domain;
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



        //ADMINISTRACION DE CLIENTES//

        public void AgregarCliente(ClientDTO pClientDTO)
        {
            Client cliente = AutoMapper.Mapper.Map<Client>(pClientDTO);

            UnitOfWork transaccion = this.CrearTransaccion();
            try
            {
                transaccion.ClientRepository.Add(cliente);
                transaccion.Complete();
            }
            catch (Exception)
            {
                throw new InvalidOperationException("El Cliente ya existe");
            }
            finally
            {
                transaccion.Dispose();
            }

        }


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

            transaccion.Complete();
            transaccion.Dispose();

        }



        public void EliminarCliente(int clientId)
        {

            UnitOfWork transaccion = this.CrearTransaccion();
                
            Client client = transaccion.ClientRepository.Get(100);

            if (client == null)
            {
                transaccion.Dispose();
                throw new InvalidOperationException("El cliente no existe");
            }

            transaccion.ClientRepository.Remove(client);
            transaccion.Complete();
            transaccion.Dispose();
        }


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

        public void AgregarCuenta(AccountDTO pAccountDTO)
        {
            Account cuenta = AutoMapper.Mapper.Map<Account>(pAccountDTO);

            UnitOfWork transaccion = this.CrearTransaccion();
            try
            {
                transaccion.AccountRepository.Add(cuenta);
                transaccion.Complete();
            }
            catch (Exception)
            {
                throw new InvalidOperationException("La cuenta ya existe");
            }
            finally
            {
                transaccion.Dispose();
            }

        }

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


    }
}
