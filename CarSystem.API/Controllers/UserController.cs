using AutoMapper;
using CarSystem.API.Models;
using CarSystem.API.Models.Domain;
using CarSystem.API.Models.DTOs.User.CreateDTOs.UserDTOs;
using CarSystem.API.Models.DTOs.User.ReadDTOs.UserDTOs;
using CarSystem.API.Models.DTOs.User.UpdateDTOs.UserDTOs;
using CarSystem.API.Models.DTOs.UserDTOs;
using CarSystem.API.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CarSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;
        private ApiResponse _response;
    
        public UserController(IUserRepository userRepository, IPersonRepository personRepository,
            IMapper mapper)
        {
            _userRepository = userRepository;
            _personRepository = personRepository;
            _mapper = mapper;
            _response = new();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResponse>> GetAll()
        {
            var users = await _userRepository.GetAllAsync();

            if(users == null)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages.Add("No users record is exists");
                _response.Result = null;
                _response.StatusCode = HttpStatusCode.BadRequest;

                return BadRequest(_response);
            }

            var usersResponse = _mapper.Map<List<ReadUserPermissionDto>>(users);

            _response.IsSuccess = true;
            _response.ErrorMessages.Add(string.Empty);
            _response.StatusCode = HttpStatusCode.OK;
            _response.Result = usersResponse;

            return Ok(_response);
        }

        [HttpGet]
        [Route("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResponse>> Get(int id)
        {
            if(id <= 0)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages.Add("given id is invalid!");
                _response.Result = null;
                _response.StatusCode = HttpStatusCode.BadRequest;

                return BadRequest(_response);
            }

            var user = await _userRepository.GetAsync(a => a.Id == id, tracked: false);

            if(user == null)
            {
                _response.ErrorMessages.Add("The user with given id is not found");
                _response.IsSuccess = false;
                _response.Result = null;
                _response.StatusCode = HttpStatusCode.BadRequest;

                return BadRequest(_response);
            }

            var userResponse = _mapper.Map<ReadUserPermissionDto>(user);

            _response.IsSuccess = true;
            _response.ErrorMessages.Add(string.Empty);
            _response.Result = userResponse;
            _response.StatusCode = HttpStatusCode.OK;

            return Ok(_response);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ApiResponse>> Create([FromBody]CreateUserDto createUserDto)
        {
            if(createUserDto == null)
            {
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.ErrorMessages.Add("The created user content is empty!");
                _response.IsSuccess = false;
                _response.Result = null;

                return BadRequest(_response);
            }

            if(!await _personRepository.IsExistAsync(p => p.Id == createUserDto.PersonId))
            {
                _response.IsSuccess = false;
                _response.Result = null;
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.ErrorMessages.Add("The person with given id don't exist!");

                return BadRequest(_response);   
            }

            if(await _userRepository.GetAsync(un => un.UserName.Trim() == createUserDto.UserName.Trim(),
                    tracked: false) != null)
            {
                _response.ErrorMessages.Add("The choosing user name is match with other, please choose another user name!");
                _response.IsSuccess = false;
                _response.Result = null;
                _response.StatusCode = HttpStatusCode.BadRequest;

                return BadRequest(_response);
            }

            var userToAdd = _mapper.Map<User>(createUserDto);
            userToAdd.CreatedAt = DateTime.UtcNow;

            var addedUser = await _userRepository.CreateAsync(userToAdd);

            if (!addedUser)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages.Add("En error exists while creating the user");
                _response.Result = null;
                _response.StatusCode = HttpStatusCode.BadRequest;
            }

            _response.IsSuccess = true;
            _response.ErrorMessages.Add(string.Empty);
            _response.StatusCode = HttpStatusCode.OK;
            _response.Result = _mapper.Map<ReadUserPermissionDto>(userToAdd);

            return Ok(_response);
        }

        [HttpPut]
        [Route("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResponse>> Update(int id, [FromBody] UpdateUserDto updateUserDto)
        {
            if(updateUserDto == null)
            {
                _response.ErrorMessages.Add("The updated user is null");
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.Result = null;
                _response.IsSuccess = false;

                return BadRequest(_response);
            }

            if(id <= 0 || updateUserDto.Id <= 0)
            {
                _response.ErrorMessages.Add("The given id is invalid!");
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.Result = null;
                _response.IsSuccess = false;

                return BadRequest(_response);
            }

            var existingUser = await _userRepository.GetAsync(u => u.Id == id, tracked: false);

            if(existingUser == null)
            {
                _response.ErrorMessages.Add("The entity with id is not exist!");
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                _response.Result = null;

                return BadRequest(_response);
            }

            if(await _userRepository.GetAsync(un => un.UserName.Trim() == updateUserDto.UserName.Trim(),
                    tracked: false) != null)
            {
                _response.ErrorMessages.Add("The give user name is exists, please choose another!");
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                _response.Result = null;
            }

            existingUser = _mapper.Map<User>(updateUserDto);

            

            var updatedUser = await _userRepository.UpdateAsync(existingUser);

            if (!updatedUser)
            {
                _response.ErrorMessages.Add("Updating field!");
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                _response.Result = null;
            }

            _response.IsSuccess = true;
            _response.ErrorMessages.Add(string.Empty);
            _response.StatusCode = HttpStatusCode.OK;
            _response.Result = _mapper.Map<ReadUserPermissionDto>(existingUser);

            return Ok(_response);
        }

        [HttpDelete]
        [Route("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResponse>> Delete(int id)
        {
            if(id <= 0)
            {
                _response.ErrorMessages.Add("The given id is invalid!");
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                _response.Result = null;

                return BadRequest(_response);
            }

            var userToDelete = await _userRepository.GetAsync(u => u.Id == id, tracked: false);

            if(userToDelete == null)
            {
                _response.ErrorMessages.Add("The user is not found");
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                _response.Result = null;

                return BadRequest(_response);
            }

            var deletedUser = await _userRepository.DeleteAsync(userToDelete);

            if(!deletedUser)
            {
                _response.ErrorMessages.Add("Deleting Field!");
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                _response.Result = null;

                return BadRequest(_response);
            }

            _response.IsSuccess = true;
            _response.ErrorMessages.Add(string.Empty);
            _response.StatusCode = HttpStatusCode.OK;
            _response.Result = null;

            return Ok(_response);
        }

    }
}
