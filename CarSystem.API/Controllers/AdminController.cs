using AutoMapper;
using CarSystem.API.Models;
using CarSystem.API.Models.Domain;
using CarSystem.API.Models.DTOs.AdminDTOs;
using CarSystem.API.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Net;

namespace CarSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly IAdminRepository _adminRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private ApiResponse _response;

        public AdminController(IAdminRepository adminRepository, IMapper mapper, IUserRepository userRepository)
        {
            _adminRepository = adminRepository;
            _userRepository = userRepository;
            _mapper = mapper;
            _response = new();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResponse>> GetAll()
        {
            var admins = await _adminRepository.GetAllAsync(includeProperties: "User");

            if(admins == null)
            {
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.ErrorMessages.Add("No admin was found");
                _response.IsSuccess = false;
                _response.Result = null;

                return BadRequest(_response);
            }

            var adminsResponse = _mapper.Map<List<AdminDto>>(admins);

            _response.IsSuccess = true;
            _response.StatusCode = HttpStatusCode.OK;
            _response.ErrorMessages.Add(string.Empty);
            _response.Result = adminsResponse;

            return Ok(_response);
        }

        [HttpGet]
        [Route("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResponse>> Get(int id)
        {
            var admin = await _adminRepository.GetAsync(x => x.Id == id, includeProperties: "User", 
                tracked: false);

            if(admin == null)
            {
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.ErrorMessages.Add("No admin was found with give id");
                _response.IsSuccess = false;
                _response.Result = null;

                return BadRequest(_response);
            }

            var adminResponse = _mapper.Map<AdminDto>(admin);

            _response.IsSuccess = true;
            _response.StatusCode = HttpStatusCode.OK;
            _response.ErrorMessages = null;
            _response.Result = adminResponse;

            return Ok(_response);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult<ApiResponse>> Create([FromBody]CreateAdminDto createAdminDto)
        {
            if(createAdminDto == null)
            {
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.IsSuccess = false;
                _response.ErrorMessages.Add("Empty admin creating is error");
                _response.Result = null;
            }

            

            if(!await _userRepository.IsExistAsync(u => u.Id == createAdminDto.UserId))
            {
                _response.IsSuccess = false;
                _response.ErrorMessages.Add("User for admin is not found");
                _response.Result = null;
                _response.StatusCode = HttpStatusCode.BadRequest;

                return BadRequest(_response);
            }

            if(await _adminRepository.IsExistAsync(a => a.UserId == createAdminDto.UserId && a.AdminLevel == createAdminDto.AdminLevel))
            {
                _response.IsSuccess = false;
                _response.ErrorMessages.Add("This level has been gave it to the current user!");
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.Result = null;

                return BadRequest(_response);
            }

            var adminToCreate = _mapper.Map<Admin>(createAdminDto);
            adminToCreate.CreatedAt = DateTime.UtcNow;

            var createdAdmin = _adminRepository.CreateAsync(adminToCreate);

            if(createdAdmin == null)
            {
                _response.ErrorMessages.Add("Admin don't created successfully!");
                _response.Result = null;
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
            }

            _response.IsSuccess = true;
            _response.ErrorMessages.Add(string.Empty);
            _response.StatusCode = HttpStatusCode.OK;
            _response.Result = _mapper.Map<AdminDto>(adminToCreate);

            return Ok(_response);
        }

        [HttpPut]
        [Route("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResponse>> Update(int id, [FromBody] UpdateAdminDto updateAdminDto)
        {
            if(updateAdminDto == null)
            {
                _response.ErrorMessages.Add("Updated field is empty!");
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                _response.Result = null;

                return BadRequest(_response);
            }

            if(updateAdminDto.Id != id)
            {
                _response.ErrorMessages.Add("The given id with updated model is not match!");
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                _response.Result = null;

                return BadRequest(_response);
            }
            
            if(Convert.ToInt16(updateAdminDto.AdminLevel) < 0 || 
                Convert.ToInt16(updateAdminDto.AdminLevel) > 2)
            {
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                _response.Result = null;
                _response.ErrorMessages.Add("Admin level should be between 3 levels");

                return BadRequest(_response);
            }

            var existingAdmin = await _adminRepository.GetAsync(a => a.Id == id, tracked: false);

            if (existingAdmin == null)
            {
                _response.Result = null;
                _response.StatusCode = HttpStatusCode.NotFound;
                _response.IsSuccess = false;
                _response.ErrorMessages.Add("The record you want update is not found!");

                return BadRequest(_response);
            }

            existingAdmin = _mapper.Map<Admin>(updateAdminDto);

            var updatedAdmin = _adminRepository.UpdateAsync(existingAdmin);

            if(!await updatedAdmin)
            {
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.IsSuccess = false;
                _response.ErrorMessages.Add("updating admin is field!");
                _response.Result = null;

                return BadRequest(_response);
            }

            _response.StatusCode = HttpStatusCode.OK;
            _response.IsSuccess = true;
            _response.ErrorMessages.Add(string.Empty);
            _response.Result = _mapper.Map<AdminDto>(updatedAdmin);

            return Ok(_response);
        }

        [HttpDelete]
        [Route("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ApiResponse>> Delete(int id)
        {
            if(id <= 0)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages.Add("The id you given is invalid!");
                _response.Result = null;
                _response.StatusCode = HttpStatusCode.BadRequest;

                return BadRequest(_response);
            }

            if(!await _adminRepository.IsExistAsync(a => a.Id == id))
            {
                _response.ErrorMessages.Add("The entity with given id is not found");
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.Result = null;
                _response.IsSuccess = false;
                
                return BadRequest(_response);
            }

            var adminToDelete = await _adminRepository.GetAsync(a => a.Id == id, tracked: false);

            var deletedAdmin = await _adminRepository.DeleteAsync(adminToDelete);

            if (!deletedAdmin)
            {
                _response.IsSuccess = false;
                _response.Result = null;
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.ErrorMessages.Add("Deleting empty don't success!");

                return BadRequest(_response);
            }


            _response.IsSuccess = true;
            _response.StatusCode = HttpStatusCode.OK;
            _response.ErrorMessages.Add(string.Empty);
            _response.Result = null;

            return Ok(_response);
        }
    }
}
