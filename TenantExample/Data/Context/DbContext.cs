using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TenantExample.Data.Context
{
    public abstract class DbContext
    {
        public abstract string ContextName { get; }
    }
}
