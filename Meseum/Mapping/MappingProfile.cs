using Meseum.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meseum.ViewModel;

namespace Meseum.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Inventory, InventoryVM>();
            CreateMap<InventoryVM, Inventory>();
            

        }
    }
}
