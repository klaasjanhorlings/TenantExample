using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TenantExample.Data.Repositories;

namespace TenantExample.Data.Services
{
    public class NameService
    {
        private readonly NameRepository _nameRepository;

        public NameService(NameRepository nameRepository)
        {
            _nameRepository = nameRepository;
        }

        public string GetContextName() => _nameRepository.GetContextName();
    }
}
