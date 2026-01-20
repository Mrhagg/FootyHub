using FootyHub.Domain.Entities;

namespace FootyHub.Application.Common.Interface;

public interface IPlayerRepository
{
    Task AddAsync(Player player);
}
