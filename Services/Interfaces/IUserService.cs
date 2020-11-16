using MPPIS.Domain.Entities;
using MPPIS.Dto;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MPPIS.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserDto> GetById(Expression<Func<User, bool>> predicate);

        Task<AddUserDto> AddUser(AddUserDto addUserDto);

        Task<UserDto> FindByEmailAsync(string email);

        Task RemoveUser(int userId);

    }
}
