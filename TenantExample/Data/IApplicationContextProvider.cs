using TenantExample.Data.Context;

namespace TenantExample.Data
{
    public interface IApplicationContextProvider
    {
        ApplicationContext Context { get; }
    }
}
