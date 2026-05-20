using FootyHub.Application.Common.Interface;
using FootyHub.Domain.Entities;
using FootyHub.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace FootyHub.Infrastructure.Persistence.Repositories;


public class TeamRepository : ITeamRepository
{
    private readonly FootyHubDbContext _context;

    public TeamRepository(FootyHubDbContext context)
    {
        _context = context;
    }


    public async Task<Team?> GetByIdAsync(Guid id)
    {
        return await _context.Teams.Include(t => t.Players).FirstOrDefaultAsync(t => t.Id == id);
    }
    public async Task UpdateAsync(Team team)
    {
        _context.Teams.Update(team);
        await _context.SaveChangesAsync();
    }

    public async Task AddAsync(Team team)
    {
        _context.Teams.Add(team);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Team>> GetAllAsync()
    {
        return await _context.Teams.Include(t => t.Players).ToListAsync();
    }
}
