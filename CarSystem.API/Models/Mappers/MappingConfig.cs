using AutoMapper;
using CarSystem.API.Models.Domain;
using CarSystem.API.Models.DTOs.AdminDTOs;
using CarSystem.API.Models.DTOs.ApplicationDTOs;
using CarSystem.API.Models.DTOs.DamageLicenseDTOs;
using CarSystem.API.Models.DTOs.DriverDTOs;
using CarSystem.API.Models.DTOs.LicenseClassDTOs;
using CarSystem.API.Models.DTOs.LicenseDTOs;
using CarSystem.API.Models.DTOs.LostLicenseDTOs;
using CarSystem.API.Models.DTOs.NationalityDTOs;
using CarSystem.API.Models.DTOs.OptionDTOs;
using CarSystem.API.Models.DTOs.PersonDTOs;
using CarSystem.API.Models.DTOs.QuestionDTOs;
using CarSystem.API.Models.DTOs.RenewalLicenseDTOs;
using CarSystem.API.Models.DTOs.TestCategoryDTOs;
using CarSystem.API.Models.DTOs.TestDTOs;
using CarSystem.API.Models.DTOs.UserDTOs;
using CarSystem.API.Models.DTOs.VisionTestDTOs;
using CarSystem.API.Models.DTOs.WritingTestDTOs;

namespace CarSystem.API.Models.Mappers
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<CreateAdminDto, Admin>().ReverseMap();
            CreateMap<UpdateAdminDto, Admin>().ReverseMap();
            CreateMap<AdminDto, Admin>().ReverseMap();

            CreateMap<CreateApplicationDto, Application>().ReverseMap();
            CreateMap<UpdateApplicationDto, Application>().ReverseMap();
            CreateMap<ApplicationDto, Application>().ReverseMap();

            CreateMap<CreateDamageLicenseDto, DamageLicense>().ReverseMap();
            CreateMap<UpdateDamageLicenseDto, DamageLicense>().ReverseMap();
            CreateMap<DamageLicenseDto, DamageLicense>().ReverseMap();

            CreateMap<CreateDriverDto, Driver>().ReverseMap();
            CreateMap<UpdateDriverDto, Driver>().ReverseMap();
            CreateMap<DriverDto, Driver>().ReverseMap();

            CreateMap<CreateLicenseDto, License>().ReverseMap();
            CreateMap<UpdateLicenseDto, License>().ReverseMap();
            CreateMap<LicenseDto, License>().ReverseMap();

            CreateMap<CreateLicenseClassDto, LicenseClass>().ReverseMap();
            CreateMap<UpdateLicenseClassDto, LicenseClass>().ReverseMap();
            CreateMap<LicenseClassDto, LicenseClass>().ReverseMap();

            CreateMap<CreateLostLicenseDto, LostLicense>().ReverseMap();
            CreateMap<UpdateLostLicenseDto, LostLicense>().ReverseMap();
            CreateMap<LostLicenseDto, LostLicense>().ReverseMap();

            CreateMap<CreateNationalityDto, Nationality>().ReverseMap();
            CreateMap<UpdateNationalityDto, Nationality>().ReverseMap();
            CreateMap<NationalityDto, Nationality>().ReverseMap();

            CreateMap<CreateOptionDto, Option>().ReverseMap();
            CreateMap<UpdateOptionDto, Option>().ReverseMap();
            CreateMap<OptionDto, Option>().ReverseMap();

            CreateMap<CreatePersonDto, Person>().ReverseMap();
            CreateMap<UpdatePersonDto, Person>().ReverseMap();
            CreateMap<PersonDto, Person>().ReverseMap();

            CreateMap<CreateQuestionDto, Question>().ReverseMap();
            CreateMap<UpdateQuestionDto, Question>().ReverseMap();  
            CreateMap<QuestionDto, Question>().ReverseMap();

            CreateMap<CreateRenewalLicenseDto, RenewalLicense>().ReverseMap();
            CreateMap<UpdateRenewalLicenseDto, RenewalLicense>().ReverseMap();
            CreateMap<RenewalLicenseDto, RenewalLicense>().ReverseMap();

            CreateMap<CreateTestDto, Test>().ReverseMap();
            CreateMap<UpdateTestDto, Test>().ReverseMap();
            CreateMap<TestDto, Test>().ReverseMap();

            CreateMap<CreateTestCategoryDto, TestCategory>().ReverseMap();
            CreateMap<UpdateTestCategoryDto, TestCategory>().ReverseMap();
            CreateMap<TestCategoryDto, TestCategory>().ReverseMap();

            CreateMap<CreateUserDto, User>().ReverseMap();
            CreateMap<UpdateUserDto, User>().ReverseMap();
            CreateMap<UserDto, User>().ReverseMap();

            CreateMap<CreateVisionTestDto, VisionTest>().ReverseMap();
            CreateMap<UpdateVisionTestDto, VisionTest>().ReverseMap();
            CreateMap<VisionTestDto, VisionTest>().ReverseMap();

            CreateMap<CreateWritingTestDto, WritingTest>().ReverseMap();
            CreateMap<UpdateWritingTestDto, WritingTest>().ReverseMap();
            CreateMap<WritingTestDto, WritingTest>().ReverseMap();
        }
    }
}
