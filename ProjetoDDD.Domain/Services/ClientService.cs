using ProjectDDD.Domain.Entity;
using ProjectDDD.Domain.Interface.Repository;
using ProjectDDD.Domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDDD.Domain.Services
{
    public class ClientService : ServiceBase<Client>, IClientService
    {
        private readonly IClientRepository _clienteRepository;

        public ClientService(IClientRepository clientRepository)
            : base(clientRepository)
        {
            _clienteRepository = clientRepository;
        }

        public IEnumerable<Client> GetSpecialClients(IEnumerable<Client> clientes)
        {
            return clientes.Where(c => c.SpecialClient(c));
        }
    }
}
