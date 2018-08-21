using ProjectDDD.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDDD.Domain.Interface.Services
{
    public interface IClientService : IServiceBase<Client>
    {
        IEnumerable<Client> GetSpecialClients(IEnumerable<Client> clientes);
    }
}
