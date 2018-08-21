using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using ProjectDDD.Domain.Entity;
using ProjectDDD.Presentation.ViewModels;
using ProjectDDD.App.Interface;

namespace ProjectDDD.Presentation.Controllers
{
  
    public class ClientesController : Controller
    {
        private readonly IClientAppService _clientAppService;

        public ClientesController(IClientAppService clientRepository)
        {
            this._clientAppService = clientRepository;
        }
        // GET: Clientes
        public ActionResult Index()
        {
            var clients = _clientAppService.GetAll();
            var clientViewModel = AutoMapper.Mapper.Map<IEnumerable<Client>, IEnumerable<ClientViewModel>>(clients);
            return View(clientViewModel);
        }

        public ActionResult Special()
        {
            var clients = _clientAppService.GetSpecialClients();
            var clientViewModel = AutoMapper.Mapper.Map<IEnumerable<Client>, IEnumerable<ClientViewModel>>(clients);
            return View(clientViewModel);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            var client = _clientAppService.GetById(id);
            var clientViewModel = AutoMapper.Mapper.Map<Client, ClientViewModel>(client);
            return View(clientViewModel);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClientViewModel client)
        {
            if (ModelState.IsValid) {
                var clientDomain = AutoMapper.Mapper.Map<ClientViewModel, Client>(client);
                _clientAppService.Add(clientDomain);
                RedirectToAction("index");
            }

            return View(client);
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            var client = _clientAppService.GetById(id);
            var clientViewModel = AutoMapper.Mapper.Map<Client, ClientViewModel>(client);
            return View(clientViewModel);

        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(ClientViewModel client)
        {
            if (ModelState.IsValid)
            {
                var clienteDomain = AutoMapper.Mapper.Map<ClientViewModel, Client>(client);
                _clientAppService.Update(clienteDomain);

                return RedirectToAction("Index");
            }

            return View(client);
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            var client = _clientAppService.GetById(id);
            var clientViewModel = AutoMapper.Mapper.Map<Client, ClientViewModel>(client);
            return View(clientViewModel);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var cliente = _clientAppService.GetById(id);
            _clientAppService.Remove(cliente);

            return RedirectToAction("Index");
        }
    }
}
