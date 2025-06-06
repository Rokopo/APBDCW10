using cw10.Data;
using cw10.Exception;
using Microsoft.EntityFrameworkCore;

namespace cw10.Service;

public class ClientService : IClientService
{
    private readonly TripsDbContext _context;

    public ClientService(TripsDbContext context)
    {
        _context = context;
    }

    public async Task DeleteClientIfHaveNotTrips(int IdClient)
    {
        var client = await _context.Clients.FindAsync(IdClient);
        if (client == null)
        {
            throw new NotFoundEX("Nie istnieje klient o podanym ID");
        }
        
        bool trips = await _context.ClientTrips.AnyAsync(c => c.IdClient == IdClient);
        if (trips)
        {
            throw new ConflictEX("Nie mozna usunac klienta ktory ma zabookowane wycieczki");
        }
        _context.Clients.Remove(client);
        await _context.SaveChangesAsync();
    }
}