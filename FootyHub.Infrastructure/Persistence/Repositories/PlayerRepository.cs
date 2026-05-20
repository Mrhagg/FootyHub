using FootyHub.Application.Common.Interface;
using FootyHub.Domain.Entities;
using FootyHub.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace FootyHub.Infrastructure.Persistence.Repositories;

public class PlayerRepository : IPlayerRepository
{
    private readonly FootyHubDbContext _context;

    public PlayerRepository(FootyHubDbContext context)
    {
        _context = context;
    }

    public async Task<List<Player>> GetByIdsAsync(IEnumerable<Guid> ids)
    {
        return await _context.Players.Where(p => ids.Contains(p.Id)).ToListAsync();
    }

    public async Task AddAsync(Player player)
    {
        _context.Players.Add(player);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Player>> GetAllAsync()
    {
        return await _context.Players.ToListAsync();
    }
}
