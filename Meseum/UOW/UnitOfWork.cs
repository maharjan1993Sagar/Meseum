using Meseum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meseum.DAL;
using Meseum.Repository;
using Meseum.IRepository;


namespace Meseum.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private MeseumContext _repoContext;

        public UnitOfWork(MeseumContext repositoryContext)
        {
            _repoContext = repositoryContext;
            Locations = new LocationRepository(_repoContext);
            Categories = new CategoryRepository(_repoContext);
            Postures = new PostureRepository(_repoContext);
            Inventories = new InventoryRepository(_repoContext);
            NewsEvents = new NewsEventRepository(_repoContext);
        }
       
        public ILocationRepository Locations{get; private set;}
        public ICategoryRepository Categories{get; private set;}
        public IPostureRepository Postures{get; private set;}
        public IInventoryRepository Inventories{get; private set;}
        public INewsEventRepository NewsEvents{get; private set;}

        public void Save()
        {
            _repoContext.SaveChanges();
        }

        public void Dispose()
        {
            _repoContext.Dispose();
        }

    }
}