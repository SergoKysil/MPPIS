using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MPPIS.Domain;
using MPPIS.Domain.Entities;
using MPPIS.Dto;
using MPPIS.Infrastructure;
using MPPIS.Services.Interfaces;
using System.Data.Entity.Core;
using System.Linq;
using System.Threading.Tasks;

namespace MPPIS.Services.Implementation
{
    public class UserService : IUserService
    {

        private readonly IRepository<User> _userRepository;
        private readonly IMapper _mapper;
        private readonly PasswordHasher<User> _passwordHasher;
        private readonly AppDbContext _context;

        public UserService(IRepository<User> userRepository, IMapper mapper, AppDbContext context)
        {
            _userRepository = userRepository;
            _context = context;
            _passwordHasher = new PasswordHasher<User>();
        }

        public async Task<AddUserDto> AddUser(AddUserDto addUserDto)
        {
            if (await _userRepository.FindByCondition(u => u.Email == addUserDto.Email) == null)
            {
                var user = _mapper.Map<User>(addUserDto);              

                user.PasswordHash = _passwordHasher.HashPassword(user, user.PasswordHash);

                _userRepository.Add(user);
                await _userRepository.SaveChangesAsync();
                return _mapper.Map<AddUserDto>(user);
            }
            else
                return null;
        }

        public async Task<UserDto> GetByIdAsync(int userId)
        {
            return _mapper.Map<UserDto>(await _userRepository.GetAll()
                .Include(p => p.Location)
                .Include(p => p.Role)
                .FirstOrDefaultAsync(x => x.Id == userId));
        }

        public async Task RemoveUser(int userId)
        {
            await using var transaction = await _context.Database.BeginTransactionAsync();
            var user = _userRepository.GetAll().FirstOrDefault(user => user.Id == userId);
            if (user == null)
            {
                throw new ObjectNotFoundException($"There is no user with id = {userId} in database");
            }
            user.IsDeleted = true;
            var affectedRows = await _userRepository.SaveChangesAsync();
            if (affectedRows == 0)
            {
                throw new DbUpdateException();
            }
            await transaction.CommitAsync();

        }
    }
}
