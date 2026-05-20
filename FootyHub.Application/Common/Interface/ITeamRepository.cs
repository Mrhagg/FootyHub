using FootyHub.Domain.Entities;

namespace FootyHub.Application.Common.Interface;

public interface ITeamRepository
{
    Task AddAsync(Team team);
    Task<Team> GetByIdAsync(Guid id);
    Task UpdateAsync(Team team);

    Task<List<Team>> GetAllAsync();
}
