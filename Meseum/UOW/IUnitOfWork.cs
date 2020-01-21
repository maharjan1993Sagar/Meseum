using Meseum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meseum.Repository;
using Meseum.IRepository;

namespace Meseum.UOW
{
    public interface IUnitOfWork :IDisposable
    { 
         ILocationRepository Locations { get; }
         ICategoryRepository Categories { get; }
         IPostureRepository Postures { get; }
         IInventoryRepository Inventories { get; }
         INewsEventRepository NewsEvents { get; }
         void Save();
    }
}
