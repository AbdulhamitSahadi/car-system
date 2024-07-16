using AutoMapper;
using CarSystem.API.Models;
using CarSystem.API.Models.Domain;
using CarSystem.API.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CarSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;
        private readonly INationalityRepository _nationalityRepository;
        private readonly IMapper _mapper;
        private ApiResponse _response;

        public PersonController(IPersonRepository personRepository, IMapper mapper, INationalityRepository ationalityRepository)
        {
            _personRepository = personRepository;
            _mapper = mapper;
            _response = new();
            _nationalityRepository = ationalityRepository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResponse>> GetAll()
        {
            var people = await _personRepository.GetAllAsync();

            if(people == null)
            {
                _response.ErrorMessages.Add("No people record has found");
                _response.Result = null;
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
            }

            var peopleResponse = _mapper.Map<List<Person>>(people);

            _response.IsSuccess = true;
            _response.ErrorMessages.Add(string.Empty);
            _response.StatusCode = HttpStatusCode.OK;
            _response.Result = peopleResponse;

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
                _response.ErrorMessages.Add("Give id is in valid");
                _response.Result = null;
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;

                return BadRequest(_response);
            }

            var person = await _personRepository.GetAsync(p => p.Id == id, tracked: false);

            if(person == null)
            {
                _response.ErrorMessages.Add("The person with id don't exist!");
                _response.IsSuccess = false;
                _response.Result = null;
                _response.StatusCode = HttpStatusCode.BadRequest;

                return BadRequest(_response);
            }

            var personResponse = _mapper.Map<ReadPersonPermissionDto>(person);

            _response.IsSuccess = true;
            _response.ErrorMessages.Add(string.Empty);
            _response.Result = personResponse;
            _response.StatusCode = HttpStatusCode.OK;

            return Ok(_response);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResponse>> Create([FromBody]CreatePersonDto createPersonDto)
        {
            if(createPersonDto == null)
            {
                _response.ErrorMessages.Add("The person you create is null");
                _response.IsSuccess = false;
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.Result = null;

                return BadRequest(_response);
            }

            if(await _personRepository.IsExistAsync(fn => (fn.FirstName.Trim() + fn.LastName.Trim()) ==
            (createPersonDto.FirstName.Trim() + createPersonDto.LastName.Trim())))
            {
                _response.ErrorMessages.Add("The full name is exist!");
                _response.IsSuccess = false;
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.Result = null;

                return BadRequest(_response);
            }

            if(await _personRepository.IsExistAsync(e => e.Email.Trim() == 
            createPersonDto.Email.Trim()))
            {
                _response.ErrorMessages.Add("The email has exist");
                _response.IsSuccess = false;
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.Result = null;

                return BadRequest(_response);
            }

            if(await _personRepository.IsExistAsync(pn => pn.PhoneNumber.Trim() ==
            createPersonDto.PhoneNumber.Trim()))
            {
                _response.ErrorMessages.Add("The phone number is exist!");
                _response.IsSuccess = false;
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.Result = null;

                return BadRequest(_response);
            }

            if(!await _nationalityRepository.IsExistAsync(ni => ni.Id == createPersonDto.NationalityId))
            {
                _response.ErrorMessages.Add("The nationality id don't found!");
                _response.IsSuccess = false;
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.Result = null;

                return BadRequest(_response);
            }

            var personToAdd = _mapper.Map<Person>(createPersonDto);

            var addedPerson = await _personRepository.CreateAsync(personToAdd);

            if (!addedPerson)
            {
                _response.ErrorMessages.Add("Error exists while creating person!");
                _response.IsSuccess = false;
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.Result = null;
            }

            _response.Result = personToAdd;
            _response.ErrorMessages.Add(string.Empty);
            _response.IsSuccess = true;
            _response.StatusCode = HttpStatusCode.OK;

            return CreatedAtAction("Get", new { id = personToAdd.Id }, _response);
        }

        [HttpPut]
        [Route("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResponse>> Update(int id, [FromBody] UpdatePersonPermissionDto updatePersonDto)
        {
            if(id <= 0 || updatePersonDto.Id <= 0)
            {
                _response.Result = null;
                _response.ErrorMessages.Add("The given id is invalid");
                _response.IsSuccess = false;
                _response.StatusCode = HttpStatusCode.BadRequest;

                return BadRequest(_response);
            }

            var existingPerson = await _personRepository.GetAsync(p => p.Id == id, tracked: false);

            if(existingPerson == null)
            {
                _response.StatusCode=HttpStatusCode.BadRequest;
                _response.IsSuccess=false;
                _response.ErrorMessages.Add("The person with id is not exists!");
                _response.Result = null;

                return BadRequest(_response);
            }

            if(await _personRepository.IsExistAsync(fn => fn.FullName.Trim().Concat(fn.LastName.Trim()) ==
            updatePersonDto.FirstName.Trim().Concat(updatePersonDto.LastName.Trim())))
            { 
                _response.IsSuccess = false;
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.ErrorMessages.Add("The name is exists!");
                _response.Result = null;

                return BadRequest(_response);
            }

            if(await _personRepository.IsExistAsync(e => e.Email.Trim() == 
            updatePersonDto.Email.Trim()))
            {
                _response.ErrorMessages.Add("Email is exist!");
                _response.IsSuccess = false;
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.Result = null;

                return BadRequest(_response);
            }

            if(await _personRepository.IsExistAsync(pn => pn.PhoneNumber.Trim()
            == updatePersonDto.PhoneNumber.Trim()))
            {
                _response.ErrorMessages.Add("Phone number is exist!");
                _response.IsSuccess = false;
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.Result = null;

                return BadRequest(_response);
            }

            existingPerson = _mapper.Map<Person>(updatePersonDto);

            var updatedPerson = await _personRepository.UpdateAsync(existingPerson);

            if (!updatedPerson)
            {
                _response.ErrorMessages.Add("An error exists while updating...");
                _response.IsSuccess = false;
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.Result = null;

                return BadRequest(_response);
            }

            _response.IsSuccess = true;
            _response.StatusCode = HttpStatusCode.OK;
            _response.ErrorMessages.Add(string.Empty);
            _response.Result = _mapper.Map<ReadPersonPermissionDto>(existingPerson);

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
                _response.ErrorMessages.Add("The id is invalid!");
                _response.IsSuccess = false;
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.Result = null;
            }

            var personToDelete = await _personRepository.GetAsync(p => p.Id == id, tracked: false);

            if(personToDelete == null)
            {
                _response.Result = null;
                _response.ErrorMessages.Add("The person with given id is not exists!");
                _response.IsSuccess = false;
                _response.StatusCode = HttpStatusCode.BadRequest;

                return BadRequest(_response);
            }

            var deletedPerson = await _personRepository.DeleteAsync(personToDelete);

            if (!deletedPerson)
            {
                _response.ErrorMessages.Add("An error existing while deleting!");
                _response.IsSuccess = false;
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.Result = null;

                return BadRequest(_response);
            }

            _response.IsSuccess = true;
            _response.StatusCode = HttpStatusCode.OK;
            _response.ErrorMessages.Add(string.Empty);
            _response.Result = null;

            return BadRequest(_response);
        }
    }
}
