using ApiOrion.DTO;
using ApiOrion.Interfaces;
using ApiOrion.Models;
using ApiOrion.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Triplex.Validations;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiOrion.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientRepository _clientRepository;

        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllClient()
        {
            List<ClientViewModel> response = await _clientRepository.GetAllClient();

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> SaveClient(ClientDTO clientDTO)
        {
            Arguments.NotNull(clientDTO, nameof(clientDTO));

            Client clientToPersistence = clientDTO.mapToPersistence();

            ClientViewModel response = await _clientRepository.SaveClient(clientToPersistence);

            return Ok(response);
        }

        [HttpPost("get-by-id")]
        public async Task<IActionResult> GetClientById(Guid clientId)
        {
            ClientViewModel response = await _clientRepository.GetClientById(clientId);

            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteClient(Guid clientId)
        {
            ClientViewModel response = await _clientRepository.DeleteClient(clientId);

            return Ok(response);
        }
    }
}
