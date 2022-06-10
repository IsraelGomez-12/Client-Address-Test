using ApiOrion.DTO;
using ApiOrion.Models;
using ApiOrion.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiOrion.Interfaces
{
    public interface IClientRepository
    {
        Task<ClientViewModel> SaveClient(Client client);
        Task<List<ClientViewModel>> GetAllClient();
        Task<ClientViewModel> GetClientById(Guid clientId);
        Task<ClientViewModel> DeleteClient(Guid clientId);
    }
}
