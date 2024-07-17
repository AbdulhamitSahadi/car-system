using AutoMapper;
using CarSystem.API.Models.Domain;
using CarSystem.API.Models.Domain.AdminDomainModels;
using CarSystem.API.Models.DTOs.UserDTOs.CreateDTOs.ApplicationDTOs;
using CarSystem.API.Models.DTOs.UserDTOs.CreateDTOs.DamageLicenseDTOs;
using CarSystem.API.Models.DTOs.UserDTOs.CreateDTOs.LostLicenseDTOs;
using CarSystem.API.Models.DTOs.UserDTOs.CreateDTOs.PersonDTOs;
using CarSystem.API.Models.DTOs.UserDTOs.CreateDTOs.RenewalLicenseDTOs;
using CarSystem.API.Models.DTOs.UserDTOs.CreateDTOs.TakeTestDTOs;
using CarSystem.API.Models.DTOs.UserDTOs.CreateDTOs.TestDTOs;
using CarSystem.API.Models.DTOs.UserDTOs.CreateDTOs.UserDTOs;
using CarSystem.API.Models.DTOs.UserDTOs.ReadDTOs.ApplicationDTOs;
using CarSystem.API.Models.DTOs.UserDTOs.ReadDTOs.DamageLicenseDTOs;
using CarSystem.API.Models.DTOs.UserDTOs.ReadDTOs.LostLicenseDTOs;
using CarSystem.API.Models.DTOs.UserDTOs.ReadDTOs.PersonDTOs;
using CarSystem.API.Models.DTOs.UserDTOs.ReadDTOs.RenewalLicenseDTOs;
using CarSystem.API.Models.DTOs.UserDTOs.ReadDTOs.TakeTestDTOs;
using CarSystem.API.Models.DTOs.UserDTOs.ReadDTOs.TestDTOs;
using CarSystem.API.Models.DTOs.UserDTOs.ReadDTOs.UserDTOs;
using CarSystem.API.Models.DTOs.UserDTOs.UpdateDTOs.ApplicationDTOs;
using CarSystem.API.Models.DTOs.UserDTOs.UpdateDTOs.DamageLicenseDTOs;
using CarSystem.API.Models.DTOs.UserDTOs.UpdateDTOs.LostLicenseDTOs;
using CarSystem.API.Models.DTOs.UserDTOs.UpdateDTOs.PersonDTOs;
using CarSystem.API.Models.DTOs.UserDTOs.UpdateDTOs.RenewalLicenseDTOs;
using CarSystem.API.Models.DTOs.UserDTOs.UpdateDTOs.TestDTOs;
using CarSystem.API.Models.DTOs.UserDTOs.UpdateDTOs.UserDTOs;
using CarSystem.API.Security.Permissions.DTOs.CreatePermissions.Admin.AdminPermissions;
using CarSystem.API.Security.Permissions.DTOs.CreatePermissions.DriverPermissions;
using CarSystem.API.Security.Permissions.DTOs.CreatePermissions.LicenseClassPermissions;
using CarSystem.API.Security.Permissions.DTOs.CreatePermissions.LicensePermissions;
using CarSystem.API.Security.Permissions.DTOs.CreatePermissions.NationalityPermissions;
using CarSystem.API.Security.Permissions.DTOs.CreatePermissions.OptionPermissions;
using CarSystem.API.Security.Permissions.DTOs.CreatePermissions.PermissionPermissions;
using CarSystem.API.Security.Permissions.DTOs.CreatePermissions.QuestionPermissions;
using CarSystem.API.Security.Permissions.DTOs.CreatePermissions.TestCategoryPermissions;
using CarSystem.API.Security.Permissions.DTOs.CreatePermissions.VisionTestPermissions;
using CarSystem.API.Security.Permissions.DTOs.ReadPermissions.AdminPermissions;
using CarSystem.API.Security.Permissions.DTOs.ReadPermissions.ApplicationPermissions;
using CarSystem.API.Security.Permissions.DTOs.ReadPermissions.DamageLicensePermissions;
using CarSystem.API.Security.Permissions.DTOs.ReadPermissions.DriverPermissions;
using CarSystem.API.Security.Permissions.DTOs.ReadPermissions.LicenseClassPermissions;
using CarSystem.API.Security.Permissions.DTOs.ReadPermissions.LicensePermissions;
using CarSystem.API.Security.Permissions.DTOs.ReadPermissions.LostLicensePermissions;
using CarSystem.API.Security.Permissions.DTOs.ReadPermissions.NationalityPermissions;
using CarSystem.API.Security.Permissions.DTOs.ReadPermissions.OptionPermissions;
using CarSystem.API.Security.Permissions.DTOs.ReadPermissions.PermissionPermissions;
using CarSystem.API.Security.Permissions.DTOs.ReadPermissions.PersonPermissions;
using CarSystem.API.Security.Permissions.DTOs.ReadPermissions.QuestionPermissions;
using CarSystem.API.Security.Permissions.DTOs.ReadPermissions.RenewalLicensePermissions;
using CarSystem.API.Security.Permissions.DTOs.ReadPermissions.TakeTestPermissions;
using CarSystem.API.Security.Permissions.DTOs.ReadPermissions.TestCategoryPermissions;
using CarSystem.API.Security.Permissions.DTOs.ReadPermissions.TestPermissions;
using CarSystem.API.Security.Permissions.DTOs.ReadPermissions.UserPermissions;
using CarSystem.API.Security.Permissions.DTOs.ReadPermissions.VisionTestPermissions;
using CarSystem.API.Security.Permissions.DTOs.ReadPermissions.WritingTestPermissions;
using CarSystem.API.Security.Permissions.DTOs.UpdatePermissions.AdminPermissions;
using CarSystem.API.Security.Permissions.DTOs.UpdatePermissions.ApplicationPermissions;
using CarSystem.API.Security.Permissions.DTOs.UpdatePermissions.DamageLicensePermissions;
using CarSystem.API.Security.Permissions.DTOs.UpdatePermissions.DriverPermissions;
using CarSystem.API.Security.Permissions.DTOs.UpdatePermissions.LicenseClassPermissions;
using CarSystem.API.Security.Permissions.DTOs.UpdatePermissions.LicensePermissions;
using CarSystem.API.Security.Permissions.DTOs.UpdatePermissions.LostLicensePermissions;
using CarSystem.API.Security.Permissions.DTOs.UpdatePermissions.NationalityPermissions;
using CarSystem.API.Security.Permissions.DTOs.UpdatePermissions.OptionPermissions;
using CarSystem.API.Security.Permissions.DTOs.UpdatePermissions.PermissionPermissions;
using CarSystem.API.Security.Permissions.DTOs.UpdatePermissions.PersonPermissions;
using CarSystem.API.Security.Permissions.DTOs.UpdatePermissions.QuestionPermissions;
using CarSystem.API.Security.Permissions.DTOs.UpdatePermissions.RenewalLicensePermissions;
using CarSystem.API.Security.Permissions.DTOs.UpdatePermissions.TakeTestPermissions;
using CarSystem.API.Security.Permissions.DTOs.UpdatePermissions.TestCategoryPermissions;
using CarSystem.API.Security.Permissions.DTOs.UpdatePermissions.TestPermissions;
using CarSystem.API.Security.Permissions.DTOs.UpdatePermissions.UserPermissions;
using CarSystem.API.Security.Permissions.DTOs.UpdatePermissions.VisionTestPermissions;
using CarSystem.API.Security.Permissions.DTOs.UpdatePermissions.WritingTestPermission;
using CarSystem.Security.Permissions.Models.CreatePermissions.WritingTestPermissions;

namespace CarSystem.API.Models.Mappers
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {

            CreateMap<CreateApplicationDto, Application>().ReverseMap();
            CreateMap<ReadApplicationDto, Application>().ReverseMap();
            CreateMap<UpdateApplicationDto, Application>().ReverseMap();


            CreateMap<CreateDamageLicenseDto, DamageLicense>().ReverseMap();
            CreateMap<ReadDamageLicenseDto, DamageLicense>().ReverseMap();
            CreateMap<UpdateDamageLicenseDto, DamageLicense>().ReverseMap();


            CreateMap<CreateLostLicenseDto, LostLicense>().ReverseMap();
            CreateMap<ReadLostLicenseDto, LostLicense>().ReverseMap();
            CreateMap<UpdateLostLicenseDto, LostLicense>().ReverseMap();
            

            CreateMap<CreatePersonDto, Person>().ReverseMap();
            CreateMap<ReadPersonDto, Person>().ReverseMap();
            CreateMap<UpdatePersonDto, Person>().ReverseMap();


            CreateMap<CreateRenewalLicenseDto, RenewalLicense>().ReverseMap();
            CreateMap<ReadRenewalLicenseDto, RenewalLicense>().ReverseMap();
            CreateMap<UpdateRenewalLicenseDto, RenewalLicense>().ReverseMap();


            CreateMap<CreateTakeTestDto, TakeTest>().ReverseMap();
            CreateMap<ReadTakeTestDto, TakeTest>().ReverseMap();


            CreateMap<CreateTestDto, Test>().ReverseMap();
            CreateMap<ReadTestDto, Test>().ReverseMap();
            CreateMap<UpdateTestDto, Test>().ReverseMap();  


            CreateMap<CreateUserDto, User>().ReverseMap();
            CreateMap<ReadUserDto, User>().ReverseMap();
            CreateMap<UpdateUserDto, User>().ReverseMap();


            CreateMap<ReadAdminAdminPermissionDto, AdminAdmin>().ReverseMap();
            CreateMap<ReadAdminApplicationPermissionDto, AdminApplication>().ReverseMap();
            CreateMap<ReadAdminDamageLicensePermissionDto, AdminDamageLicense>().ReverseMap();
            CreateMap<ReadAdminDriverPermissionDto, AdminDriver>().ReverseMap();
            CreateMap<ReadAdminLicenseClassPermissionDto, AdminLicenseClass>().ReverseMap();
            CreateMap<ReadAdminLicensePermissionDto, AdminLicense>().ReverseMap();
            CreateMap<ReadAdminLostLicensePermissionDto, AdminLostLicense>().ReverseMap();
            CreateMap<ReadAdminNationalityPermissionDto, AdminNationality>().ReverseMap();
            CreateMap<ReadAdminOptionPermissionDto, AdminOption>().ReverseMap();
            CreateMap<ReadAdminPersonPermissionDto, AdminPerson>().ReverseMap();
            CreateMap<ReadAdminQuestionPermissionDto,  AdminQuestion>().ReverseMap();
            CreateMap<ReadAdminRenewalLicensePermissionDto, AdminRenewalLicense>().ReverseMap();
            CreateMap<ReadAdminTakeTestPermissionDto, AdminTakeTest>().ReverseMap();
            CreateMap<ReadAdminTestCategoryPermissionDto, AdminTestCategory>().ReverseMap();
            CreateMap<ReadAdminTestPermissionDto, AdminTest>().ReverseMap();
            CreateMap<ReadAdminUserPermissionDto, AdminUser>().ReverseMap();
            CreateMap<ReadAdminVisionTestPermissionDto, AdminVisionTest>().ReverseMap();
            CreateMap<ReadAdminWritingTestPermissionDto, AdminWritingTest>().ReverseMap();


            CreateMap<ReadApplicationPermissionDto, Application>().ReverseMap();
            CreateMap<ReadDamageLicensePermissionDto, DamageLicense>().ReverseMap();
            CreateMap<ReadDriverPermissionDto, Driver>().ReverseMap();
            CreateMap<ReadLicenseClassPermissionDto, LicenseClass>().ReverseMap();
            CreateMap<ReadLicensePermissionDto, License>().ReverseMap();
            CreateMap<ReadLostLicensePermissionDto, LostLicense>().ReverseMap();
            CreateMap<ReadNationalityPermissionDto, Nationality>().ReverseMap();
            CreateMap<ReadOptionPermissionDto, Option>().ReverseMap();
            CreateMap<ReadPermissionPermissionDto, Permission>().ReverseMap();
            CreateMap<ReadPersonPermissionDto, Person>().ReverseMap();
            CreateMap<ReadQuestionPermissionDto, Question>().ReverseMap();
            CreateMap<ReadRenewalLicensePermissionDto, RenewalLicense>().ReverseMap();
            CreateMap<ReadTakeTestPermissionDto, TakeTest>().ReverseMap();
            CreateMap<ReadTestCategoryPermissionDto,TestCategory>().ReverseMap();
            CreateMap<ReadTestPermissionDto, Test>().ReverseMap();
            CreateMap<ReadUserPermissionDto, User>().ReverseMap();
            CreateMap<ReadVisionTestPermissionDto, VisionTest>().ReverseMap();
            CreateMap<ReadWritingTestPermissionDto, WritingTest>().ReverseMap();


            CreateMap<CreateAdminPermissionDto, Admin>().ReverseMap();
            CreateMap<CreateDriverPermissionDto, Driver>().ReverseMap();
            CreateMap<CreateLicenseClassPermissionDto, LicenseClass>().ReverseMap();
            CreateMap<CreateLicensePermissionDto, License>().ReverseMap();
            CreateMap<CreateNationalityPermissionDto, Nationality>().ReverseMap();
            CreateMap<CreateOptionPermissionDto, Option>().ReverseMap();
            CreateMap<CreatePermissionDto, Permission>().ReverseMap();
            CreateMap<CreateQuestionPermissionDto, Question>().ReverseMap();
            CreateMap<CreateTestCategoryPermissionDto, TestCategory>().ReverseMap();
            CreateMap<CreateVisionTestPermissionDto, VisionTest>().ReverseMap();
            CreateMap<CreateWritingTestPermissionDto, WritingTest>().ReverseMap();


            CreateMap<UpdateAdminPermissionDto, Admin>().ReverseMap();
            CreateMap<UpdateApplicationPermissionDto, Application>().ReverseMap();
            CreateMap<UpdateDamageLicensePermissionDto, DamageLicense>().ReverseMap();
            CreateMap<UpdateDriverPermissionDto, Driver>().ReverseMap();
            CreateMap<UpdateLicenseClassPermissionDto, LicenseClass>().ReverseMap();
            CreateMap<UpdateLicensePermissionDto, License>().ReverseMap();
            CreateMap<UpdateLostLicensePermissionDto, LostLicense>().ReverseMap();
            CreateMap<UpdateNationalityPermissionDto, Nationality>().ReverseMap();
            CreateMap<UpdateOptionPermissionDto, Option>().ReverseMap();
            CreateMap<UpdatePermissionPermissionDto, Permission>().ReverseMap();
            CreateMap<UpdatePersonPermissionDto, Person>().ReverseMap();
            CreateMap<UpdateQuestionPermissionDto, Question>().ReverseMap();
            CreateMap<UpdateRenewalLicensePermissionDto, RenewalLicense>().ReverseMap();
            CreateMap<UpdateTakeTestPermissionDto, TakeTest>().ReverseMap();
            CreateMap<UpdateTestCategoryPermissionDto, TestCategory>().ReverseMap();
            CreateMap<UpdateTestPermissionDto, Test>().ReverseMap();
            CreateMap<UpdateUserPermissionDto, User>().ReverseMap();
            CreateMap<UpdateVisionTestPermissionDto,  VisionTest>().ReverseMap();
            CreateMap<UpdateWritingTestPermissionDto,  WritingTest>().ReverseMap();


            //CreateMap<CreateAdminDto, Admin>().ReverseMap();
            //CreateMap<UpdateAdminDto, Admin>().ReverseMap();
            //CreateMap<AdminDto, Admin>().ReverseMap();

            //CreateMap<CreateApplicationDto, Application>().ReverseMap();
            //CreateMap<UpdateApplicationDto, Application>().ReverseMap();
            //CreateMap<ApplicationDto, Application>().ReverseMap();

            //CreateMap<CreateDamageLicenseDto, DamageLicense>().ReverseMap();
            //CreateMap<UpdateDamageLicenseDto, DamageLicense>().ReverseMap();
            //CreateMap<DamageLicenseDto, DamageLicense>().ReverseMap();

            //CreateMap<CreateDriverDto, Driver>().ReverseMap();
            //CreateMap<UpdateDriverDto, Driver>().ReverseMap();
            //CreateMap<DriverDto, Driver>().ReverseMap();

            //CreateMap<CreateLicenseDto, License>().ReverseMap();
            //CreateMap<UpdateLicenseDto, License>().ReverseMap();
            //CreateMap<LicenseDto, License>().ReverseMap();

            //CreateMap<CreateLicenseClassDto, LicenseClass>().ReverseMap();
            //CreateMap<UpdateLicenseClassDto, LicenseClass>().ReverseMap();
            //CreateMap<ReadLicenseClassPermissionDto, LicenseClass>().ReverseMap();

            //CreateMap<CreateLostLicenseDto, LostLicense>().ReverseMap();
            //CreateMap<UpdateLostLicenseDto, LostLicense>().ReverseMap();
            //CreateMap<ReadLostLicensePermissionDto, LostLicense>().ReverseMap();

            //CreateMap<CreateNationalityDto, Nationality>().ReverseMap();
            //CreateMap<UpdateNationalityDto, Nationality>().ReverseMap();
            //CreateMap<ReadNationalityPermissionDto, Nationality>().ReverseMap();

            //CreateMap<CreateOptionDto, Option>().ReverseMap();
            //CreateMap<UpdateOptionDto, Option>().ReverseMap();
            //CreateMap<OptionDto, Option>().ReverseMap();

            //CreateMap<CreatePersonDto, Person>().ReverseMap();
            //CreateMap<UpdatePersonPermissionDto, Person>().ReverseMap();
            //CreateMap<ReadPersonPermissionDto, Person>().ReverseMap();

            //CreateMap<CreateQuestionDto, Question>().ReverseMap();
            //CreateMap<UpdateQuestionDto, Question>().ReverseMap();  
            //CreateMap<QuestionDto, Question>().ReverseMap();

            //CreateMap<CreateRenewalLicenseDto, RenewalLicense>().ReverseMap();
            //CreateMap<UpdateRenewalLicenseDto, RenewalLicense>().ReverseMap();
            //CreateMap<ReadRenewalLicensePermissionDto, RenewalLicense>().ReverseMap();

            //CreateMap<CreateTestDto, Test>().ReverseMap();
            //CreateMap<UpdateTestDto, Test>().ReverseMap();
            //CreateMap<ReadTestDto, Test>().ReverseMap();

            //CreateMap<CreateTestCategory, TestCategory>().ReverseMap();
            //CreateMap<UpdateTestCategoryPermissionDto, TestCategory>().ReverseMap();
            //CreateMap<ReadTestCategoryPermissionDto, TestCategory>().ReverseMap();

            //CreateMap<CreateUserDto, User>().ReverseMap();
            //CreateMap<UpdateUserDto, User>().ReverseMap();
            //CreateMap<ReadUserPermissionDto, User>().ReverseMap();

            //CreateMap<CreateVisionTestDto, VisionTest>().ReverseMap();
            //CreateMap<UpdateVisionTestDto, VisionTest>().ReverseMap();
            //CreateMap<VisionTestDto, VisionTest>().ReverseMap();

            //CreateMap<CreateWritingTestDto, WritingTest>().ReverseMap();
            //CreateMap<UpdateWritingTestDto, WritingTest>().ReverseMap();
            //CreateMap<WritingTestDto, WritingTest>().ReverseMap();
        }
    }
}
