﻿using Meseum.Models;
using Meseum.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Meseum.DAL;

namespace Meseum.Repository
{
    public class LocationRepository : Repository<Location>, ILocationRepository
    {
        public LocationRepository(MeseumContext Context)
            : base(Context)
        {
        }

        public MeseumContext MeseumContext
        {
            get { return db as MeseumContext; }

        }
        //public IEnumerable<AnimalRegistration> GetModel()
        //{
        //    return db.animalRegistration.Include(M => M.Species).Include(m => m.Breed).Include(m=>m.Farm).Include(m=>m.AnimalOwners).ToList();

        //}

      
    }
}
