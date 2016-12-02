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
                    .ForMember(dest => dest.TypeDocument, opt => opt.MapFrom(src => src.Document.Type));

                cfg.CreateMap<ClientDTO, Client>()
                    .ForMember(dest => dest.Document, opt => opt.MapFrom(src => new Document() { Number = src.NumberDocument, Type = (DocumentType)src.TypeDocument }));
            }
            );

                
            
            Application.Run(new FormMenu());
        }
    }
}
