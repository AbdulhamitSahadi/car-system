using AutoMapper;
using CarSystem.API.Models;
using CarSystem.API.Models.DTOs.DriverDTOs;
using CarSystem.API.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CarSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DriverController : ControllerBase
    {
        private readonly IDriverRepository _driverRepository;
        private readonly IAdminRepository _adminRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private ApiResponse _response;

        public DriverController(IDriverRepository driverRepository,
            IAdminRepository adminRepository, IUserRepository userRepository, IMapper mapper)
        {
            _driverRepository = driverRepository;
            _adminRepository = adminRepository;
            _userRepository = userRepository;
            _mapper = mapper;
            _response = new();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResponse>> GetAll()
        {
            var drivers = await _driverRepository.GetAllAsync();

            if(drivers == null)
            {
                _response.ErrorMessages.Add("No driver records was found!");
                _response.Result = null;
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;

                return BadRequest(_response);
            }

            var driversResponse = _mapper.Map<DriverDto>(drivers);

            _response.IsSuccess = true;
            _response.ErrorMessages.Add(string.Empty);
            _response.Result = driversResponse;
            _response.StatusCode = HttpStatusCode.OK;

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
                _response.ErrorMessages.Add("The given id is invalid");
                _response.Result = null;
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;

                return BadRequest(_response);
            }

            var driver = await _driverRepository.GetAsync(d => d.Id == id, tracked: false);

            if(driver == null)
            {
                _response.ErrorMessages.Add("The driver with given id not found!");
                _response.IsSuccess = false;
                _response.Result = null;
                _response.StatusCode = HttpStatusCode.BadRequest;

                return BadRequest(_response);
            }


            var driverResponse = _mapper.Map<DriverDto>(driver);

            _response.IsSuccess = true;
            _response.Result = driverResponse;
            _response.StatusCode = HttpStatusCode.OK;
            _response.ErrorMessages.Add(string.Empty);

            return Ok(_response);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResponse>> Create([FromBody]CreateDriverDto createDriverDto)
        {
            if(create)
        }
    }
}
