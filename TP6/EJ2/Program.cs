using EJ2.Domain;
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
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Client, ClientDTO>()
                    .ForMember(dest => dest.NumberDocument, opt => opt.MapFrom(src => src.Document.Number))
                    .ForMember(dest => dest.TypeDocument, opt => opt.MapFrom(src => DocTypeAString(src.Document.Type)));

                cfg.CreateMap<ClientDTO, Client>()
                    .ForMember(dest => dest.Document, opt => opt.MapFrom(src => new Document() { Number = src.NumberDocument, Type = stringADocType(src.TypeDocument) }));

                cfg.CreateMap<Account, AccountDTO>()
                    .ForMember(dest => dest.ClientId, opt => opt.MapFrom(src => src.Client.Id))
                    .ForMember(dest => dest.ClientName, opt => opt.MapFrom(src => src.Client.LastName + ", "+src.Client.FirstName));

                cfg.CreateMap<AccountDTO, Account>()
                    .ForMember(dest => dest.Client, opt => opt.MapFrom(src => new Client()
                    {
                        Id = src.ClientId
                    }));
                cfg.CreateMap<AccountMovement, AccountMovementDTO>();
            }
            );

                
            
            Application.Run(new FormMenu());
        }

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
