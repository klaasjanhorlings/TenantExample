using System;

namespace TenantExample.Data
{
    public interface ITenantScopeProvider
    {
        IDisposable WithTenant(string tenantName);
    }
}
