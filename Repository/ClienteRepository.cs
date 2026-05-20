using Microsoft.EntityFrameworkCore;
using API_PetCare_Connect.Data.Models;
using API_PetCare_Connect.Repository.IRepository;

namespace API_PetCare_Connect.Repository;

public class ClienteRepository : Repository<Cliente>, IClienteRepository
{
    private readonly PetCareConnectContext _context;

    public ClienteRepository(PetCareConnectContext context) : base(context)
    {
        _context = context;
    }

    public async Task<Cliente?> GetByDniAsync(string dni)
    {
        return await _context.Clientes.FirstOrDefaultAsync(c => c.DniCliente == dni);
    }
}
