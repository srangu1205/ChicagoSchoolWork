using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChicagoSchoolsAPI.Models
{
   
        public class DistrictMeanISATMathMeetsExceeds
        {
            [JsonProperty("@i:nil")]
            public string INil { get; set; }
        }

        public class DistrictMeanISATReadingMeetsExceeds
        {
            [JsonProperty("@i:nil")]
            public string INil { get; set; }
        }

        public class DistrictMeanISATScienceMeetsExceeds
        {
            [JsonProperty("@i:nil")]
            public string INil { get; set; }
        }

        public class ISATMathMeetsExceeds
        {
            [JsonProperty("@i:nil")]
            public string INil { get; set; }
        }

        public class ISATReadingMeetsExceeds
        {
            [JsonProperty("@i:nil")]
            public string INil { get; set; }
        }

        public class ISATScienceMeetsExceeds
        {
            [JsonProperty("@i:nil")]
            public string INil { get; set; }
        }

        public class IsPreschoolInclusive
        {
            [JsonProperty("@i:nil")]
            public string INil { get; set; }
        }

        public class IsPreschoolInstructional
        {
            [JsonProperty("@i:nil")]
            public string INil { get; set; }
        }

        public class SchoolProfileDocument
        {
            public string DocumentPeriod { get; set; }
            public string DocumentTitle { get; set; }
            public string DownloadURL { get; set; }
            public string SchoolID { get; set; }
            public string SortOrderDocumentTab { get; set; }
            public string SortOrderDocumentType { get; set; }
            public string TabDescription { get; set; }
        }

        public class ProfileDocuments
        {
            public List<SchoolProfileDocument> SchoolProfileDocument { get; set; }
        }

        public class ProgramScoreID
        {
            [JsonProperty("@i:nil")]
            public string INil { get; set; }
        }

        public class ProgramTierID
        {
            [JsonProperty("@i:nil")]
            public string INil { get; set; }
        }

        public class APIGetSchoolProgramAdmissionsResult
        {
            public string ApplicationDeadline { get; set; }
            public string HasGeographicEntitlement { get; set; }
            public object PreviousYearApplicationCount { get; set; }
            public object PreviousYearOfferCount { get; set; }
            public string ProgramApplicationRequirements { get; set; }
            public string ProgramCode { get; set; }
            public string ProgramGradesServed { get; set; }
            public string ProgramRollupGroup { get; set; }
            public string ProgramRollupType { get; set; }
            public ProgramScoreID ProgramScoreID { get; set; }
            public ProgramTierID ProgramTierID { get; set; }
            public string ProgramType { get; set; }
            public string SchoolApplicationRequirements { get; set; }
            public string SchoolDataProgramAdmissionsID { get; set; }
            public string SchoolID { get; set; }
            public string SchoolProgramYear { get; set; }
            public string SelectionCriteria { get; set; }
            public string SubPrograms { get; set; }
        }

        public class Programs
        {
            public List<APIGetSchoolProgramAdmissionsResult> API_GetSchoolProgramAdmissions_Result { get; set; }
        }

        public class SchoolProfile
        {
            public string ADAAccessibility { get; set; }
            public string AddressCity { get; set; }
            public string AddressLatitude { get; set; }
            public string AddressLongitude { get; set; }
            public string AddressState { get; set; }
            public string AddressStreet { get; set; }
            public string AddressZipCode { get; set; }
            public string AdministratorFullName { get; set; }
            public string AdministratorTitle { get; set; }
            public string AfterSchoolHours { get; set; }
            public string AlertMessage { get; set; }
            public string AttendanceRateCurrentYear { get; set; }
            public string ClassificationDescription { get; set; }
            public string ClassroomLanguages { get; set; }
            public DateTime CloseDate { get; set; }
            public string CollegeEnrollmentRate { get; set; }
            public string CultureRating { get; set; }
            public string DemographicsSummary { get; set; }
            public string DistrictMeanCollegeEnrollmentRate { get; set; }
            public string DistrictMeanGraduationRate { get; set; }
            public string DistrictMeanISATCompositeMeetsExceeds { get; set; }
            public DistrictMeanISATMathMeetsExceeds DistrictMeanISATMathMeetsExceeds { get; set; }
            public DistrictMeanISATReadingMeetsExceeds DistrictMeanISATReadingMeetsExceeds { get; set; }
            public DistrictMeanISATScienceMeetsExceeds DistrictMeanISATScienceMeetsExceeds { get; set; }
            public string DistrictMeanPSAECompositeMeetsExceeds { get; set; }
            public string EarliestDropOffTime { get; set; }
            public string FacebookURL { get; set; }
            public string Fax { get; set; }
            public string FifthContactFullName { get; set; }
            public string FifthContactTitle { get; set; }
            public string FinanceID { get; set; }
            public string FourthContactFullName { get; set; }
            public string FourthContactTitle { get; set; }
            public string FreshmanHours { get; set; }
            public string Governance { get; set; }
            public string GradesOffered { get; set; }
            public string GradesOfferedReadable { get; set; }
            public string GraduationRate { get; set; }
            public string GraduationRate4Year { get; set; }
            public string HasAttendanceBoundary { get; set; }
            public string HasBilingualServices { get; set; }
            public string HasDressCode { get; set; }
            public string HasRefugeeServices { get; set; }
            public object ISATCompositeMeetsExceeds { get; set; }
            public ISATMathMeetsExceeds ISATMathMeetsExceeds { get; set; }
            public ISATReadingMeetsExceeds ISATReadingMeetsExceeds { get; set; }
            public ISATScienceMeetsExceeds ISATScienceMeetsExceeds { get; set; }
            public string Introduction { get; set; }
            public string IsElementarySchool { get; set; }
            public string IsGoCPSParticipant { get; set; }
            public string IsHighSchool { get; set; }
            public string IsMiddleSchool { get; set; }
            public string IsPreSchool { get; set; }
            public IsPreschoolInclusive IsPreschoolInclusive { get; set; }
            public IsPreschoolInstructional IsPreschoolInstructional { get; set; }
            public string IsTitle1Eligible { get; set; }
            public string KinderGartenSchoolDay { get; set; }
            public string LegacyUnitID { get; set; }
            public string LogoFileName { get; set; }
            public string MagnetThemes { get; set; }
            public string Network { get; set; }
            public DateTime OpenDate { get; set; }
            public string OverallRating { get; set; }
            public string OverallRatingDescription { get; set; }
            public string OverallRatingReadable { get; set; }
            public string OverallRatingStatus { get; set; }
            public string PSAECompositeMeetsExceeds { get; set; }
            public string Phone { get; set; }
            public string PinterestURL { get; set; }
            public string PreKSchoolDay { get; set; }
            public string PrimaryCategory { get; set; }
            public ProfileDocuments ProfileDocuments { get; set; }
            public Programs Programs { get; set; }
            public string ProgramsCollegeAndCareer { get; set; }
            public string ProgramsCollegePrep { get; set; }
            public string ProgramsCreative { get; set; }
            public string ProgramsHealthAndWellness { get; set; }
            public string ProgramsLifeAndLeadership { get; set; }
            public string ProgramsParentAndCommunity { get; set; }
            public string ProgramsScholastic { get; set; }
            public string ProgramsSchoolWide { get; set; }
            public string ProgramsSportsAndFitness { get; set; }
            public string SATSchoolAverage { get; set; }
            public string SafetyRating { get; set; }
            public string SchoolHours { get; set; }
            public string SchoolID { get; set; }
            public string SchoolLongName { get; set; }
            public string SchoolShortName { get; set; }
            public string SchoolType { get; set; }
            public string SchoolYearReadable { get; set; }
            public string SecondContactFullName { get; set; }
            public string SecondContactTitle { get; set; }
            public string SeventhContactFullName { get; set; }
            public string SeventhContactTitle { get; set; }
            public string SixthContactFullName { get; set; }
            public string SixthContactTitle { get; set; }
            public string StatisticsSummary { get; set; }
            public string StudentCount { get; set; }
            public string StudentCountAsian { get; set; }
            public string StudentCountAsianPacificIslander { get; set; }
            public string StudentCountBlack { get; set; }
            public string StudentCountEthnicityOther { get; set; }
            public string StudentCountEthnicityUnavailable { get; set; }
            public string StudentCountHawaiianPacificIslander { get; set; }
            public string StudentCountHispanic { get; set; }
            public string StudentCountLimitedEnglishLearners { get; set; }
            public string StudentCountLowIncome { get; set; }
            public string StudentCountMultiEthnic { get; set; }
            public string StudentCountNativeAmerican { get; set; }
            public string StudentCountSpecialEducation { get; set; }
            public string StudentCountWhite { get; set; }
            public string ThirdContactFullName { get; set; }
            public string ThirdContactTitle { get; set; }
            public string TrackType { get; set; }
            public string TransportationBus { get; set; }
            public string TransportationEL { get; set; }
            public string TransportationMetra { get; set; }
            public string TwitterURL { get; set; }
            public string WebsiteURL { get; set; }
            public string YoutubeURL { get; set; }
        }

        public class ArrayOfSchoolProfile
        {
            [JsonProperty("@xmlns:i")]
            public string XmlnsI { get; set; }
            [JsonProperty("@xmlns")]
            public string Xmlns { get; set; }
            public List<SchoolProfile> SchoolProfile { get; set; }
        }

        public class Root
        {
            public ArrayOfSchoolProfile ArrayOfSchoolProfile { get; set; }
        }

    
}