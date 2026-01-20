using FootyHub.Application.Common.Interface;
using FootyHub.Domain.Entities;
using FootyHub.Infrastructure.Persistence.Context;

namespace FootyHub.Infrastructure.Persistence.Repositories;

public class PlayerRepository : IPlayerRepository
{
    private readonly FootyHubDbContext _context;

    public PlayerRepository(FootyHubDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Player player)
    {
        _context.Players.Add(player);
        await _context.SaveChangesAsync();
    }
}
