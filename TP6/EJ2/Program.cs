﻿using EJ2.Domain;
using EJ2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Agregamos a la configuracion del Automapper los mapeos que vamos a 
             * utilizar entre las clases de dominio y los DTO
             */
            AutoMapper.Mapper.Initialize(cfg =>
            {
                //Mapeo de Client a ClientDTO
                cfg.CreateMap<Client, ClientDTO>()
                    .ForMember(dest => dest.NumberDocument, opt => opt.MapFrom(src => src.Document.Number))
                    .ForMember(dest => dest.TypeDocument, opt => opt.MapFrom(src => DocTypeAString(src.Document.Type)));
                
                //Mapeo de ClientDTO a Client
                cfg.CreateMap<ClientDTO, Client>()
                    .ForMember(dest => dest.Document, opt => opt.MapFrom(src => new Document() { Number = src.NumberDocument, Type = stringADocType(src.TypeDocument) }));

                //Mapeo de Account a AccountDTO
                cfg.CreateMap<Account, AccountDTO>()
                    .ForMember(dest => dest.ClientId, opt => opt.MapFrom(src => src.Client.Id))
                    .ForMember(dest => dest.ClientName, opt => opt.MapFrom(src => src.Client.LastName + ", "+src.Client.FirstName));

                //Mapeo de AccountDTO a Account
                cfg.CreateMap<AccountDTO, Account>()
                    .ForMember(dest => dest.Client, opt => opt.MapFrom(src => new Client()
                    {
                        Id = src.ClientId
                    }));

                //Mapeo de AccountMovement a AccountMovementDTO
                cfg.CreateMap<AccountMovement, AccountMovementDTO>();
            }
            );

                
            
            Application.Run(new FormMenu());
        }



        /// <summary>
        /// Convierte de cadena a tipo de documento
        /// </summary>
        /// <param name="pTipoDocumento">Una cadena</param>
        /// <returns>Un tipo de documento</returns>
        private static DocumentType stringADocType(string pTipoDocumento)
        {
            switch (pTipoDocumento)
            {
                case "DNI":
                    return DocumentType.DNI;

                case "CUIL":
                    return DocumentType.CUIL;

                case "LC":
                    return DocumentType.LC;

                case "LE":
                    return DocumentType.LE;
                default:
                    throw new ArgumentException("Tipo de documento no Valido");
            }
        }

        /// <summary>
        /// Convierte de tipo de documento a cadena
        /// </summary>
        /// <param name="pTipoDocumento">Un tipo de documento</param>
        /// <returns>Una cadena con el tipo de documento</returns>
        private static string DocTypeAString(DocumentType pTipoDocumento)
        {
            switch (pTipoDocumento)
            {
                case DocumentType.DNI:
                    return "DNI";

                case DocumentType.CUIL:
                    return "CUIL";

                case DocumentType.LC:
                    return "LC";

                case DocumentType.LE:
                    return "LE";
                default:
                    throw new ArgumentException("Tipo de documento no Valido");
            }
        }
    }   
}
