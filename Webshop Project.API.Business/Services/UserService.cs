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
        private readonly IGenericRepo<UserEntity> _userRepository;
        private readonly IGenericRepo<BasketEntity> _basketRepository;
        private IMapper _mapper;

        public UserService(IGenericRepo<UserEntity> userRepository, IMapper mapper, IGenericRepo<BasketEntity> basketRepository)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _basketRepository = basketRepository;
        }

        public async Task<User> GetUserAsync(int id)
        {
            User user = new User();
            UserEntity userEntity = await _userRepository.GetItemByIDAsync(id);

            if (userEntity == null)
            {
                return null;
            }

            user = _mapper.Map<User>(userEntity);
            return user;
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            IEnumerable<UserEntity> userEntities = await _userRepository.GetAllItemAsync();
            IEnumerable<User> users = _mapper.Map<IEnumerable<User>>(userEntities);

            return users;
        }

        public async Task AddUserAsync(User user)
        {
            UserEntity userEntity = _mapper.Map<UserEntity>(user);
            userEntity.Created = DateTime.Now;
            userEntity.Updated = DateTime.Now;

            await _userRepository.AddItemAsync(userEntity);
        }

        public async Task DeleteUserAsync(int id)
        {
            UserEntity userEntity = new UserEntity()
            {
                ID = id
            };
            await _userRepository.DeleteItemByIDAsync(userEntity);
        }

        public async Task UpdateUserAsync(int id, User user)
        {
            UserEntity userEntity = await _userRepository.GetItemByIDAsync(id);
            UserEntity updateUserEntity = _mapper.Map<UserEntity>(user);

            userEntity.Name = updateUserEntity.Name;
            userEntity.Role = updateUserEntity.Role;
            userEntity.Email = updateUserEntity.Email;
            userEntity.Password = updateUserEntity.Password;
            userEntity.Updated = DateTime.Now;

            await _userRepository.UpdateItemAsync(userEntity);
        }

        public async Task MakeUserInactiveAsync(int id)
        {
            UserEntity userEntity = await _userRepository.GetItemByIDAsync(id);

            await _userRepository.MakeItemInactiveAsync(userEntity);
            //await _basketRepository.MakeItemInactiveAsync(userEntity.BasketID);
        }
    }
}
