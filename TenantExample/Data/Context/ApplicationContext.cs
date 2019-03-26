using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TenantExample.Data.Context
{
    public class ApplicationContext: DbContext
    {
        private readonly string connectionString;

        public ApplicationContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public override string ContextName => $"ApplicationContext ({connectionString})";
    }
}
