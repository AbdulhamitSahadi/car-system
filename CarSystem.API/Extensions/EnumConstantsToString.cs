using CarSystem.API.Enums;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace CarSystem.API.Extensions
{
    public static class EnumConstantsToString
    {
        public static string LicenseClassTypeToString(this LicenseClassType licenseClassType)
        {
            switch (licenseClassType)
            {
                case LicenseClassType.ClassA:
                    return "Large Vehicles";
                case LicenseClassType.ClassB:
                    return "Small Vehicles";
                case LicenseClassType.ClassC:
                    return "Standard Driver";
                case LicenseClassType.ClassD:
                    return "Passenger Vehicles";
                case LicenseClassType.ClassM:
                    return "Motorcycles Class";
                case LicenseClassType.ClassP:
                    return "Provisional Class";
                case LicenseClassType.ClassE:
                    return "Heavy Trucks";
                case LicenseClassType.ClassF:
                    return "Farm Class";
                case LicenseClassType.ClassG:
                    return "Graduated Class";
                case LicenseClassType.ClassH:
                    return "Hazardous Materials";
                case LicenseClassType.ClassI:
                    return "Military Vehicles";
                case LicenseClassType.ClassJ:
                    return "Special Vehicles";
            }

            return string.Empty;
        }

        public static string AdminLevelToString(this AdminLevel adminLevel)
        {
            switch (adminLevel)
            {
                case AdminLevel.SuperAdmin:
                    return "Super Admin";
                case AdminLevel.Admin:
                    return "Admin";
            }

            return string.Empty;
        }

        public static string StatusToString(this Status status)
        {
            switch (status)
            {
                case Status.Approved:
                    return "Approved";
                case Status.Rejected:
                    return "Rejected";
                case Status.Pending:
                    return "Pending";
            }

            return  string.Empty;
        }

        public static string ApplicationTypeToString(this ApplicationType applicationType)
        {
            switch (applicationType)
            {
                case ApplicationType.New:
                    return "New";
                case ApplicationType.Damage:
                    return "Damage";
                case ApplicationType.Lost:
                    return "Lost";
                case ApplicationType.Renewal:
                    return "Renewal";
                case ApplicationType.Test:
                    return "Test";
            }

            return string.Empty;
        }

        public static string GenderToString(this Gender gender)
        {
            switch (gender)
            {
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
            }

            return string.Empty;
        }

        public static string ReleaseTypeToString(this ReleaseType releaseType)
        {
            switch (releaseType)
            {
                case ReleaseType.New:
                    return "New";
                case ReleaseType.Damage:
                    return "Damage";
                case ReleaseType.Lost:
                    return "Lost";
                case ReleaseType.Renewal:
                    return "Renewal";
            }

            return string.Empty;
        }

        public static string TestTypeToString(this TestStatus testType)
        {
            switch (testType)
            {
                case TestStatus.New:
                    return "New";
                case TestStatus.Retake:
                    return "Retake";
            }

            return string.Empty;
        }

        public static string TestStatusToString(this TestStatus testStatus)
        {
            switch (testStatus)
            {
                case TestStatus.New:
                    return "New";
                case TestStatus.Retake:
                    return "Retake";
            }

            return string.Empty;
        }

        public static string QuestionTypeToString(this QuestionType questionType)
        {
            switch (questionType)
            {
                case QuestionType.Vision:
                    return "Vision";
                case QuestionType.Writing:
                    return "Writing";
            }

            return string.Empty;
        }

        public static string PermissionTypeToString(this PermissionType permissionType)
        {
            switch (permissionType)
            {
                case PermissionType.Critical:
                    return "Critical";
                case PermissionType.Uncritical:
                    return "UnCritical";
            }

            return string.Empty;
        }

        public static string PermissionNameToString(this PermissionName permissionName)
        {
            switch(permissionName)
            {
                case PermissionName.CreateAdmin:
                    return "Create Admin";
                case PermissionName.CreateDriver:
                    return "Create Driver";
                case PermissionName.CreateLicenseClass:
                    return "Create License Class";
                case PermissionName.CreateLicense:
                    return "Create License";
                case PermissionName.CreateNationality:
                    return "Create Nationality";
                case PermissionName.CreateOption:
                    return "Create Option";
                case PermissionName.CreateQuestion:
                    return "Create Question";
                case PermissionName.CreateTestCategory:
                    return "Create Test Category";
                case PermissionName.CreateVisionTest:
                    return "Create Vision Test";
                case PermissionName.CreateWritingTest:
                    return "Create Writing Test";
                case PermissionName.ReadAdminAdmin:
                    return "Read Admin Admin";
                case PermissionName.ReadAdminApplication:
                    return "Read Admin Application";
                case PermissionName.ReadAdminDamageLicense:
                    return "Read Admin Damage License";
                case PermissionName.ReadAdminDriver:
                    return "Read Admin Driver";
                case PermissionName.ReadAdminLicenseClass:
                    return "Read Admin License Class";
                case PermissionName.ReadAdminLicense:
                    return "Read Admin License";
                case PermissionName.ReadAdminLostLicense:
                    return "Read Admin Lost License";
                case PermissionName.ReadAdminNationality:
                    return "ReadAdminNationality";
                case PermissionName.ReadAdminOption:
                    return "Read Admin Option";
                case PermissionName.ReadAdminPerson:
                    return "Read Admin Person";
                case PermissionName.ReadAdminQuestion:
                    return "Read Admin Question";
                case PermissionName.ReadAdminRenewalLicense:
                    return "Read Admin Renewal License";
                case PermissionName.ReadAdminTakeTest:
                    return "Read Admin Take Test";
                case PermissionName.ReadAdminTestCategory:
                    return "Read Admin Test Category";
                case PermissionName.ReadAdminTest:
                    return "Read Admin Test";
                case PermissionName.ReadAdminUser:
                    return "Read Admin User";
                case PermissionName.ReadAdminVisionTest:
                    return "Read Admin Vision Test";
                case PermissionName.ReadAdminWritingTest:
                    return "Read Writing Test";
                case PermissionName.ReadApplication:
                    return "Read Application";
                case PermissionName.ReadDamageLicense:
                    return "Read Damage License";
                case PermissionName.ReadDriver:
                    return "Read Driver";
                case PermissionName.ReadLicenseClass:
                    return "Read License Class";
                case PermissionName.ReadLicense:
                    return "Read License";
                case PermissionName.ReadLostLicense:
                    return "Read Lost License";
                case PermissionName.ReadNationality:
                    return "Read Nationality";
                case PermissionName.ReadOption:
                    return "Read Option";
                case PermissionName.ReadPerson:
                    return "Read Person";
                case PermissionName.ReadQuestion:
                    return "Read Question";
                case PermissionName.ReadRenewalLicense:
                    return "Read Renewal License";
                case PermissionName.ReadTakeTest:
                    return "Read Take Test";
                case PermissionName.ReadTestCategory:
                    return "Read Test Category";
                case PermissionName.ReadTest:
                    return "Read Test";
                case PermissionName.ReadUser:
                    return "Read User";
                case PermissionName.ReadVisionTest:
                    return "Read Vision Test";
                case PermissionName.ReadWritingTest:
                    return "Read Writing Test";
                case PermissionName.UpdateAdmin:
                    return "UpdateAdmin";
                case PermissionName.UpdateApplication:
                    return "Update Application";
                case PermissionName.UpdateDamageLicense:
                    return "Update Damage License";
                case PermissionName.UpdateDriver:
                    return "Update Driver";
                case PermissionName.UpdateLicenseClass:
                    return "Update License Class";
                case PermissionName.UpdateLicense:
                    return "Update License";
                case PermissionName.UpdateLostLicense:
                    return "Update Lost License";
                case PermissionName.UpdateNationality:
                    return "Update Nationality";
                case PermissionName.UpdateOption:
                    return "Update Option";
                case PermissionName.UpdatePerson:
                    return "Update Person";
                case PermissionName.UpdateQuestion:
                    return "Update Question";
                case PermissionName.UpdateRenewalLicense:
                    return "Update Renewal License";
                case PermissionName.UpdateTakeTest:
                    return "Update Take Test";
                case PermissionName.UpdateTestCategory:
                    return "Update Test Category";
                case PermissionName.UpdateTest:
                    return "Update Test";
                case PermissionName.UpdateUser:
                    return "Update User";
                case PermissionName.UpdateVisionTest:
                    return "Update Vision Test";
                case PermissionName.UpdateWritingTest:
                    return "Update Writing Test";
            }

            return string.Empty;
        }
    }
}
