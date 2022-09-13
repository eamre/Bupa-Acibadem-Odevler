using AutoMapper;
using Bupa.Entity.Dto;
using Bupa.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bupa.Entity.Mapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Card, DtoCard>().ReverseMap();
            CreateMap<Policy, DtoPolicy>().ReverseMap();
            CreateMap<Order, DtoOrder>().ReverseMap();
            CreateMap<OrderDetail, DtoOrderDetail>().ReverseMap();
            CreateMap<PolicyOwner, DtoPolicyOwner>().ReverseMap();
            CreateMap<InstallmentOption, DtoInstallmentOption>().ReverseMap();
            CreateMap<Customer, DtoCustomer>().ReverseMap();
            CreateMap<PaymentMethod, DtoPaymentMethod>().ReverseMap();

        }
    }
}
