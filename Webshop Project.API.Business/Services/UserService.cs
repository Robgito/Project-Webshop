using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop_Project.API.Business.Models;
using Webshop_Project.API.Data.Entities;
using Webshop_Project.API.Data.Repositories;

namespace Webshop_Project.API.Business.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<User> GetUserAsync(int id)
        {
            User user = new User();
            UserEntity userEntity = await _userRepository.GetUserByIDAsync(id);

            if (userEntity == null)
            {
                return null;
            }

            user = _mapper.Map<User>(userEntity);
            return user;
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            IEnumerable<UserEntity> userEntities = await _userRepository.GetAllUsersAsync();
            IEnumerable<User> users = _mapper.Map<IEnumerable<User>>(userEntities);

            return users;
        }

        public async Task AddUserAsync(User user)
        {
            UserEntity userEntity = _mapper.Map<UserEntity>(user);
            userEntity.Created = DateTime.Now;
            userEntity.Updated = DateTime.Now;

            await _userRepository.AddUserAsync(userEntity);
        }

        public async Task DeleteUserAsync(int id)
        {
            await _userRepository.DeleteUserByIDAsync(id);
        }

        public async Task UpdateUserAsync(int id, User user)
        {
            UserEntity userEntity = await _userRepository.GetUserByIDAsync(id);
            UserEntity updateUserEntity = _mapper.Map<UserEntity>(user);

            userEntity.Name = updateUserEntity.Name;
            userEntity.Role = updateUserEntity.Role;
            userEntity.Email = updateUserEntity.Email;
            userEntity.Password = updateUserEntity.Password;
            userEntity.Updated = DateTime.Now;

            await _userRepository.UpdateUserAsync(userEntity);
        }
    }
}
