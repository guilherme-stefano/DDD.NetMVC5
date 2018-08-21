using ProjectDDD.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDDD.App.Interface;
using ProjectDDD.Domain.Interface.Services;
using ProjectDDD.Domain.Services;

namespace ProjectDDD.App
{
    public class ClientAppService : AppServiceBase<Client> , IClientAppService
    {
        private readonly IClientService _clientService;
        public ClientAppService(IClientService clientService) : base(clientService)
        {
            this._clientService = clientService;  
        }

        public IEnumerable<Client> GetSpecialClients()
        {
            return this._clientService.GetSpecialClients(_clientService.GetAll());
        }
    }
}
