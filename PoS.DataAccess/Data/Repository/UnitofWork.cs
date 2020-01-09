using PoS.DataAccess.Data.Repository.iRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PoS.DataAccess.Data.Repository
{
    public class UnitofWork: IUnitofWork
    {
        private readonly ApplicationDbContext _db;

        public UnitofWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
        }

        public ICategory Category { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
