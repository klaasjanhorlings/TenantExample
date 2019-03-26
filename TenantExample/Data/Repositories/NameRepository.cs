using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TenantExample.Data.Repositories
{
    public class NameRepository
    {
        private readonly IApplicationContextProvider _contextProvider;

        public NameRepository(IApplicationContextProvider contextProvider)
        {
            _contextProvider = contextProvider;
        }

        public string GetContextName() => _contextProvider.Context.ContextName;
    }
}
