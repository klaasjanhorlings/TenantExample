using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TenantExample.Data.Context;

namespace TenantExample.Data.Repositories
{
    public class TenantsRepository
    {
        private readonly TenantsContext tenantsContext;

        public TenantsRepository(TenantsContext tenantsContext)
        {
            this.tenantsContext = tenantsContext;
        }

        public string GetConnectionString(string tenantName) => $"connection={tenantName.ToUpperInvariant()}";
    }
}
