using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EKSystemApp.Domain.Common;

namespace EKSystemApp.Domain.Entities.Member
{
    public class ResumeModel : BaseEntity
    {
        public string CaarerAim { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string AreaCode { get; set; }
        public string TelefoneNumber { get; set; }
        public string Email { get; set; }
        public string Provice { get; set; }
        public string Distict { get; set; }
        public string CarDokument { get; set; }
        public string Nationalty { get; set; }
        public string TCIdentityNumber { get; set; }
        public DateTime DischargeDate { get; set; }
        public string ExemptionName { get; set; }
        public string EducationLewel { get; set; }
        public string SchollName { get; set; }
        public string SectionName { get; set; }
        public string ContinueStatus { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime GruadiationDate { get; set; }
        public string ForeignLanguageInfo { get; set; }
        public string ForeignLanguageReadLewel { get; set; }
        public string ForeignLanguageWriteLewel { get; set; }
        public string ForeignLanguageSpeakLewel { get; set; }
        public bool Experience { get; set; }
        public string CompanyName { get; set; }
        public string WorkingDepartman { get; set; }
        public string PositionTaskName { get; set; }
        public string WorkingCountry { get; set; }
        public string WorkingProvince { get; set; }
        public DateTime ExistDate { get; set; }
        public int MyProperty { get; set; }
        public string  PreferredSector { get; set; }
        public int Wage { get; set; }
        public string Currency { get; set; }
        public int CurrencyType { get; set; }
        public string FlexibleWorking { get; set; }
        public string Reach { get; set; }
        public string WorkingRelative { get; set; }
        public string WorkingRelativeName { get; set; }
        public bool IlluminationText { get; set; }
        public bool ExpressConsent { get; set; }
        public bool AcceptDeclarecommitment { get; set; }
        public bool Referance { get; set; }

        public string Country { get; set; }
        public string Address { get; set; }
        public string LeaveReason { get; set; }
        public int YourCurrency { get; set; }
        public string DetailCurrencyType { get; set; }
        public string DetailCurrency { get; set; }
        public string ManagerName { get; set; }
        public string ManagerProfession { get; set; }
        public string CanContact { get; set; }
        public string ZoneCode { get; set; }    
        public string TelNumber { get; set; }
        public string Skills { get; set; }
        public string SkillLevel { get; set;}
        public string ProgramName { get; set;}
        public string EducationalInstitution { get;}
        public int EducationTime { get; set; }
        public string CertificateDate { get; set; }
        public string MemberCommunity { get; set; }
        public string Scholarship { get; set; }
        public string Hobis { get; set; }
        public string PressWorkingTime   { get; set; }
        public string PressCard { get; set; }
        public string HealthProblem { get; set;}
        public string RegistryRecord { get; set; }
        public string Registration { get; set; }
        public string UrgentContactPersonName { get; set; }
        public string UrgentContactPersonZoneCode { get; set; }
        public string UrgentContactPersonTelNumber { get; set; }
        public string DesiredSideBenefits { get; set; }
        public string ReferanceName { get; set; }
        public string ReferanceTitle { get;set; }
        public string ReferanceWorkingLocaiton { get; set; }
        public string ReferanceDatingTime { get;set; }
        public string ReferanceZoneCode { get; set; }
        public string ReferanceTelNumber { get; set; }
        public string InstagramLink { get; set; }
        public string TwitterLink { get; set; }
        public string FacebookLink { get; set;}
        public string LinkedinLink { get; set;}
    }

}

