using CarSystem.API.Enums;

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

        public static string ApplicationStatusToString(this Status applicationStatus)
        {
            switch (applicationStatus)
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
    }
}
