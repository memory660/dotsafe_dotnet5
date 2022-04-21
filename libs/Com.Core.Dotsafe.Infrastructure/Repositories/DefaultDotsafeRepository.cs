using Com.Core.Dotsafe.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Core.Dotsafe.Infrastructure.Data;

namespace Com.Core.Dotsafe.Infrastructure.Repositories
{
    public class DefaultDotsafeRepository : IDotsafeRepository
    {
        #region Fields
        private readonly DotsafesContext _context = null;
        #endregion

        #region Constructors
        public DefaultDotsafeRepository(DotsafesContext context)
        {
            this._context = context;
        }
        #endregion
    }
}
