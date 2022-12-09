using PrafullaBooks.DataAccess.Repository.IRepository;
using PrafullaBooks.Models;
using PrafullaBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrafullaBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType coverType)
        {
            // throw new NotImplementedException();
            //use .Net LINQ to retrieve the first or default coverType object,
            //then pass the id as a generic entity which matches the coverType ID
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null) //save changes if not null
            {
                objFromDb.Name = coverType.Name;
                //_db.SaveChanges();
            }
        }
    }
}
