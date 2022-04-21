using Com.Core.Dotsafe.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Com.Core.Dotsafe.Domain
{
    public class IDotsafeRepository : IRepository
    {
        public IUnitOfWork UnitOfWork => throw new NotImplementedException();
    }
}
