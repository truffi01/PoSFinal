using System;
using System.Collections.Generic;
using System.Text;

namespace PoS.DataAccess.Data.Repository.iRepository
{
    public interface IUnitofWork: IDisposable
    {
        ICategory Category { get; }

        void Save();
    }
}
