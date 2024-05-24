using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webshop_Project.API.Business.Models;
using Webshop_Project.API.Business.Services;
using Webshop_Project.DTO;

namespace Webshop_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        private IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<UserDTO>> GetSpecificUserAsync(int id)
        {
            User user = await _userService.GetUserAsync(id);
            UserDTO userDTO = _mapper.Map<UserDTO>(user);

            if(user == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(userDTO);
            }
        }

        [HttpGet]
        [Route("GetAllUsers")]
        public async Task<ActionResult<UserDTO>> GetAllUsersAsync()
        {
            IEnumerable<User> users = await _userService.GetUsersAsync();
            IEnumerable<UserDTO> userDTOs = _mapper.Map<IEnumerable<UserDTO>>(users);

            if(users == null || users.Count() == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(userDTOs);
            }
        }

        [HttpPost]
        public async Task<ActionResult> AddUserAsync(AddUserDTO addUserDTO)
        {
            if (ModelState.IsValid)
            {
                User user = _mapper.Map<User>(addUserDTO);
                await _userService.AddUserAsync(user);
                return Created();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteUserAsync(int id)
        {
            await _userService.DeleteUserAsync(id);
            return Created();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateUserAsync(int id, UpdateUserDTO updateUserDTO)
        {
            if (ModelState.IsValid)
            {
                User user = _mapper.Map<User>(updateUserDTO);
                await _userService.UpdateUserAsync(id, user);
                return Created();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
