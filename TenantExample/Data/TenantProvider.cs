using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TenantExample.Data.Context;
using TenantExample.Data.Repositories;

namespace TenantExample.Data
{
    internal class TenantProvider : IApplicationContextProvider, ITenantScopeProvider
    {
        private readonly TenantsRepository _tenantsRepository;
        private readonly Stack<ApplicationContext> _contexts;

        public TenantProvider(ApplicationContext initial, TenantsRepository tenantsRepository)
        {
            _tenantsRepository = tenantsRepository;

            _contexts = new Stack<ApplicationContext>();
            _contexts.Push(initial);
        }

        public ApplicationContext Context => _contexts.Peek();

        public IDisposable WithTenant(string tenantName)
        {
            var connectionString = _tenantsRepository.GetConnectionString(tenantName);
            var context = new ApplicationContext(connectionString);
            _contexts.Push(context);
            return new TenantScope(this);
        }

        private class TenantScope: IDisposable
        {
            private readonly TenantProvider provider;

            public TenantScope(TenantProvider provider)
            {
                this.provider = provider;
            }

            public void Dispose() => provider._contexts.Pop();
        }
    }
}
