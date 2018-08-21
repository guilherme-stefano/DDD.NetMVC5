using ProjectDDD.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDDD.App.Interface
{
    public interface IClientAppService : IAppServiceBase<Client>
    {
        IEnumerable<Client> GetSpecialClients();
    }
}
