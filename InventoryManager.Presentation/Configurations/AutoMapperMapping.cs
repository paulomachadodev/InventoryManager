using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManager.Core.DTOs;
using InventoryManager.Presentation.Models;
using InventoryManager.Presentation.ViewModels;

namespace InventoryManager.Core.Configurations
{
    public class AutoMapperMapping : Profile
    {
        public AutoMapperMapping()
        {
            CreateMap<MerchandiseRegisterDto, MerchandiseRegisterViewModel>();
            CreateMap<MerchandiseRegisterViewModel, MerchandiseGetDto>();
            CreateMap<TransactionRegisterDto, TransactionRegisterViewModel>();
            CreateMap<TransactionRegisterViewModel,TransactionRegisterDto>();
        }
    }
}