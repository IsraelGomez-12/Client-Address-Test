using ApiOrion.DTO;
using ApiOrion.Interfaces;
using ApiOrion.Models;
using ApiOrion.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiOrion.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly Context _context;
        public ClientRepository(Context context)
        {
            _context = context;
        }

        async Task<ClientViewModel> IClientRepository.DeleteClient(Guid clientId)
        {
            Client clientToDelete = await _context.Clients.FirstOrDefaultAsync(client => client.ClientId == clientId).ConfigureAwait(true);
            _context.Clients.Remove(clientToDelete);
            await _context.SaveChangesAsync().ConfigureAwait(true);

            return clientToDelete.mapToView();
        }

        async Task<List<ClientViewModel>> IClientRepository.GetAllClient()
        {
            List<Client> clients = await _context.Clients.ToListAsync().ConfigureAwait(true);

            List<ClientViewModel> clientViewModels = clients.Select(client => client.mapToView()).ToList();

            return clientViewModels;
        }

        async Task<ClientViewModel> IClientRepository.GetClientById(Guid clientId)
        {
            Client client = await _context.Clients.FirstOrDefaultAsync(client => client.ClientId == clientId).ConfigureAwait(true);

            return client.mapToView();
        }

        async Task<ClientViewModel> IClientRepository.SaveClient(Client client)
        {
            await _context.Clients.AddAsync(client).ConfigureAwait(true);
            await _context.Addresses.AddRangeAsync(client.Addresses).ConfigureAwait(true);
            await _context.SaveChangesAsync().ConfigureAwait(true);

            return client.mapToView();

        }
    }
}
