using Shared.Infrastructures;
using Shared.Infrastructures.Extensions;
using Stl.CommandR.Configuration;
using Stl.Fusion;

namespace Shared.Features
{
    public interface IUserService : IComputeService
    {
        [ComputeMethod]
        Task<TableResponse<UserView>> GetAll(TableOptions options, CancellationToken cancellationToken = default);
        
        [ComputeMethod]
        Task<UserView> Get(long Id, CancellationToken cancellationToken = default);
        
        [CommandHandler]
        Task<bool> Create(CreateUserCommand command, CancellationToken cancellationToken = default);

        [CommandHandler]
        Task Delete(DeleteUserCommand command, CancellationToken cancellationToken = default);

        [CommandHandler]
        Task Update(UpdateUserCommand command, CancellationToken cancellationToken = default);
    }
}
