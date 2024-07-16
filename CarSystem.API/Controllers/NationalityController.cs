using AutoMapper;
using CarSystem.API.Models;
using CarSystem.API.Models.Domain;
using CarSystem.API.Models.DTOs.NationalityDTOs;
using CarSystem.API.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CarSystem.API.Controllers
{ 
    [ApiController]
    [Route("api/[controller]")]
    public class NationalityController : ControllerBase
    {
        private readonly INationalityRepository _nationalityRepository;
        private readonly IMapper _mapper;
        private ApiResponse _response;

        public NationalityController(INationalityRepository nationalityRepository, IMapper mapper)
        {
            _nationalityRepository = nationalityRepository;
            _mapper = mapper;
            _response = new();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResponse>> GetAll()
        {
            var nationalities = await _nationalityRepository.GetAllAsync();

            if(nationalities == null)
            {
                _response.Result = null;
                _response.ErrorMessages.Add("No nationality was found!");
                _response.IsSuccess = false;
                _response.StatusCode = HttpStatusCode.BadRequest;

                return BadRequest(_response);
            }

            var nationalitiesResponse = _mapper.Map<List<ReadNationalityPermissionDto>>(nationalities);

            _response.IsSuccess = true;
            _response.ErrorMessages.Add(string.Empty);
            _response.StatusCode = HttpStatusCode.BadRequest;
            _response.Result = nationalitiesResponse;

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
                _response.ErrorMessages.Add("The given id is not valid!");
                _response.IsSuccess = false;
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.Result = null;

                return BadRequest(_response);
            }

            var nationality = await _nationalityRepository.GetAsync(n => n.Id == id, tracked: false);

            if(nationality == null)
            {
                _response.Result = null;
                _response.ErrorMessages.Add("The nationality with given id is not found!");
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;

                return BadRequest(_response);
            }

            var nationalityResponse = _mapper.Map<ReadNationalityPermissionDto>(nationality);

            _response.IsSuccess = true;
            _response.Result = nationalityResponse;
            _response.ErrorMessages.Add(string.Empty);
            _response.StatusCode = HttpStatusCode.BadRequest;

            return Ok(_response);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResponse>> Create([FromBody] CreateNationalityDto createNationalityDto)
        {
            if(await _nationalityRepository.IsExistAsync(nn => nn.Name.Trim() ==
            createNationalityDto.Name.Trim()))
            {
                _response.ErrorMessages.Add("The name of country is exist, please choose another one!");
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.Result = null;
                _response.IsSuccess = false;

                return BadRequest(_response);
            }

            var nationalityToAdd = _mapper.Map<Nationality>(createNationalityDto);

            var addedNationality = await _nationalityRepository.CreateAsync(nationalityToAdd);

            if (!addedNationality)
            {
                _response.ErrorMessages.Add("Error exists while creating the nationality!");
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                _response.Result = null;

                return BadRequest(_response);
            }


            _response.ErrorMessages.Add(string.Empty);
            _response.StatusCode = HttpStatusCode.OK;
            _response.IsSuccess = true;
            _response.Result = null;

            return Ok(_response);
        }


        [HttpPut]
        [Route("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResponse>> Update(int id, [FromBody] UpdateNationalityDto updateNationalityDto)
        {
            if(id <= 0 || updateNationalityDto.Id <= 0)
            {
                _response.ErrorMessages.Add("The given id is invalid!");
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                _response.Result = null;

                return BadRequest(_response);   
            }

            if(id != updateNationalityDto.Id)
            {
                _response.ErrorMessages.Add("The id you give is not match with nationalities's id");
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                _response.Result = null;

                return BadRequest(_response);
            }

            if(updateNationalityDto == null)
            {
                _response.ErrorMessages.Add("The nationlity you are updating is null");
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                _response.Result = null;

                return BadRequest(_response);
            }

            if(await _nationalityRepository.IsExistAsync(nn => nn.Name.Trim() == updateNationalityDto.Name.Trim()))
            {
                _response.ErrorMessages.Add("The name is exists, please choose another!");
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                _response.Result = null;

                return BadRequest(_response);
            }

            var nationalityToUpdate = _mapper.Map<Nationality>(updateNationalityDto);

            bool updatedNationality = await _nationalityRepository.UpdateAsync(nationalityToUpdate);

            if(!updatedNationality)
            {
                _response.ErrorMessages.Add("En error is exists while updating the entity!");
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                _response.Result = null; 

                return BadRequest(_response);
            }

            _response.IsSuccess = true;
            _response.ErrorMessages.Add(string.Empty);
            _response.StatusCode = HttpStatusCode.OK;
            _response.Result = _mapper.Map<ReadNationalityPermissionDto>(nationalityToUpdate);   

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
                _response.ErrorMessages.Add("The given id is not valid!");
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                _response.Result = null;
                
                return BadRequest(_response) ;
            }

            var nationalityToDelete = await _nationalityRepository.GetAsync(n => n.Id == id, tracked: false);

            if(nationalityToDelete == null)
            {
                _response.IsSuccess = false;
                _response.Result = null;
                _response.ErrorMessages.Add("The nationality with given id is not found!");
                _response.StatusCode = HttpStatusCode.BadRequest;

                return BadRequest(_response) ;
            }

            bool deletedNationality = await _nationalityRepository.DeleteAsync(nationalityToDelete);

            if(!deletedNationality)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages.Add("En error exist while deleting...");
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.Result = null;

                return BadRequest(_response) ;
            }

            _response.IsSuccess = true;
            _response.ErrorMessages.Add(string.Empty);
            _response.StatusCode = HttpStatusCode.OK;
            _response.Result = null;

            return Ok(_response);
        }
    }
}
