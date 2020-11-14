using MPPIS.Dto;
using System.Threading.Tasks;

namespace MPPIS.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserDto> GetByIdAsync(int userId);

        Task<AddUserDto> AddUser(AddUserDto addUserDto);

        Task RemoveUser(int userId);

    }
}
