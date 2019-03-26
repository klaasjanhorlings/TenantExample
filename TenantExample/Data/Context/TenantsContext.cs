using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TenantExample.Data.Context
{
    public class TenantsContext : DbContext
    {
        public override string ContextName => "TenantContext";
    }
}
