using AutoMapper;
using EKSystemApp.Application.DTO.Advert.List;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.DTO.Eba.TMP.OrganizationTree;
using EKSystemApp.Domain.Entities.eBA;
using EKSystemApp.Domain.Entities.eBA.ForeignLanguages;
using EKSystemApp.Domain.Entities.eBA.GeneralSkills;

namespace EKSystemApp.Application.Mappings.Eba
{
    public class EbaProfile : Profile
    {
        public EbaProfile()
        {
            CreateMap<TmpZhrCalisanPersWs, TmpZhrCalisanPersWsDto>().ReverseMap();

            CreateMap<TmpOrganizationTree, TmpOrganizationTreeDto>().ReverseMap();

            CreateMap<TmpOrganizationTreeDr, TmpOrganizationTreeDto>().ReverseMap();

            CreateMap<TmpOrganizationTreeDto, EbaGorevTempDto>()
                .ForMember(dest => dest.UpObjectId, opt => opt.MapFrom(src => src.OBJID))
                .ForMember(dest => dest.Pozisyon, opt => opt.MapFrom(src => src.ORGTX));

            CreateMap<TmpOrganizationTree, EbaKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.OBJID))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.ORGTX));

            CreateMap<TmpOrganizationTree, GroupTreeDto>()
                .ForMember(dest => dest.UpKey, opt => opt.MapFrom(src => src.UP_OBJID))
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.OBJID))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.ORGTX));

            CreateMap<TmpOrganizationTree, DepartmentTreeDto>()
                .ForMember(dest => dest.UpKey, opt => opt.MapFrom(src => src.UP_OBJID))
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.OBJID))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.ORGTX));

            CreateMap<TmpOrganizationTree, UnitTreeDto>()
                .ForMember(dest => dest.UpKey, opt => opt.MapFrom(src => src.UP_OBJID))
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.OBJID))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.ORGTX));

            CreateMap<GorevlerFullSap, EbaKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.UNVAN_TANIM));

            CreateMap<Titles, EbaKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.TANIM));
            CreateMap<Titles, EbaStrKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.ID.ToString()))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.TANIM));

            CreateMap<Locations, EbaKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.TANIM));

            CreateMap<StaffType, EbaKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.TANIM));

            CreateMap<WorkingType, EbaKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.TANIM));
            CreateMap<WorkingType, EbaStrKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.ID.ToString()))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.TANIM));

            CreateMap<EducationStatus, EbaKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.TANIM));
            
            CreateMap<EducationStatus, EbaStrKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.ID.ToString()))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.TANIM));

            CreateMap<ShiftStatus, EbaStrKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.TANIM));

            CreateMap<MilitaryStatus, EbaStrKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.TANIM));

            CreateMap<M_Languages, EbaStrKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.TxtYabanciDilKod))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.TxtYabanciDilAd));

            CreateMap<LanguageLevels, EbaStrKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.TANIM));

            CreateMap<M_Skills, EbaKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.TxtProfesyonelBeceriKod))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.TxtProfesyonelBeceriAd));

            CreateMap<SkillLevels, EbaStrKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.TANIM));

            CreateMap<Genders, EbaStrKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.TANIM));

            CreateMap<TmpZhrCalisanPersWs, EbaOrgKeyStrKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.ORGKEY))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.ORGKEY));

            CreateMap<TmpZhrCalisanPersWs, EbaStrKvpDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.ZORG))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.ORGTX));

            CreateMap<TmpZhrCalisanPersWs, OrganizationTreeDto>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.ZORG))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.ORGTX));

            CreateMap<IseAlimForm, EbaIseAlimTurkuvazFormDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ID))
                .ForPath(dest => dest.Organization.Key, opt => opt.MapFrom(src => src.cmbOrganizasyon))
                .ForPath(dest => dest.Organization.Value, opt => opt.MapFrom(src => src.cmbOrganizasyon_TEXT))
                .ForPath(dest => dest.Group.Key, opt => opt.MapFrom(src => src.cmbGrup))
                .ForPath(dest => dest.Group.Value, opt => opt.MapFrom(src => src.cmbGrup_TEXT))
                .ForPath(dest => dest.Department.Key, opt => opt.MapFrom(src => src.cmbBolum))
                .ForPath(dest => dest.Department.Value, opt => opt.MapFrom(src => src.cmbBolum_TEXT))
                .ForPath(dest => dest.Unit.Key, opt => opt.MapFrom(src => src.cmbBirim))
                .ForPath(dest => dest.Unit.Value, opt => opt.MapFrom(src => src.cmbBirim_TEXT))
                .ForPath(dest => dest.Profession.Key, opt => opt.MapFrom(src => src.cmbGorev))
                .ForPath(dest => dest.Profession.Value, opt => opt.MapFrom(src => src.cmbGorev_TEXT))
                .ForPath(dest => dest.Position.Key, opt => opt.MapFrom(src => src.cmbUnvan))
                .ForPath(dest => dest.Position.Value, opt => opt.MapFrom(src => src.cmbUnvan_TEXT))
                .ForPath(dest => dest.ShiftStatus.Key, opt => opt.MapFrom(src => src.cmbKadroDurum))
                .ForPath(dest => dest.ShiftStatus.Value, opt => opt.MapFrom(src => src.cmbKadroDurum_TEXT))
                .ForPath(dest => dest.MilitaryStatus.Key, opt => opt.MapFrom(src => src.cmbAskerlikDurumu))
                .ForPath(dest => dest.MilitaryStatus.Value, opt => opt.MapFrom(src => src.cmbAskerlikDurumu_TEXT))
                .ForPath(dest => dest.EducationStatus.Key, opt => opt.MapFrom(src => src.cmbEgitimDurum))
                .ForPath(dest => dest.EducationStatus.Value, opt => opt.MapFrom(src => src.cmbEgitimDurum_TEXT))
                .ForPath(dest => dest.StaffType.Key, opt => opt.MapFrom(src => src.cmbKadroSekli))
                .ForPath(dest => dest.StaffType.Value, opt => opt.MapFrom(src => src.cmbKadroSekli_TEXT))
                .ForPath(dest => dest.WorkingType.Key, opt => opt.MapFrom(src => src.cmbCalismaSekli))
                .ForPath(dest => dest.WorkingType.Value, opt => opt.MapFrom(src => src.cmbCalismaSekli_TEXT))
                .ForPath(dest => dest.Location.Key, opt => opt.MapFrom(src => src.cmbLokasyon))
                .ForPath(dest => dest.Location.Value, opt => opt.MapFrom(src => src.cmbLokasyon_TEXT))
                .ForPath(dest => dest.Gender.Key, opt => opt.MapFrom(src => src.cmbCinsiyet))
                .ForPath(dest => dest.Gender.Value, opt => opt.MapFrom(src => src.cmbCinsiyet_TEXT))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.txtIsTanim));
            
            CreateMap<IseAlimForm, AdvertListDto>()
                .ForPath(dest => dest.Id, opt => opt.MapFrom(src => new Guid()))
                .ForPath(dest => dest.WorkDefination, opt => opt.MapFrom(src => src.txtIsTanim))
                .ForPath(dest => dest.PositionValue, opt => opt.MapFrom(src => src.cmbUnvan_TEXT))
                .ForPath(dest => dest.CompanyName, opt => opt.MapFrom(src => src.cmbSirket_TEXT))
                .ForPath(dest => dest.OrganizationName, opt => opt.MapFrom(src => src.cmbOrganizasyon_TEXT))
                .ForPath(dest => dest.GroupName, opt => opt.MapFrom(src => src.cmbGrup_TEXT))
                .ForPath(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.cmbBolum_TEXT))
                .ForPath(dest => dest.UnitName, opt => opt.MapFrom(src => src.cmbBirim_TEXT))
                .ForPath(dest => dest.WorkTypeName, opt => opt.MapFrom(src => src.cmbCalismaSekli_TEXT))
                .ForPath(dest => dest.LocationName, opt => opt.MapFrom(src => src.cmbLokasyon_TEXT))
                .ForPath(dest => dest.EducationLevelName, opt => opt.MapFrom(src => src.cmbEgitimDurum_TEXT))
                .ForPath(dest => dest.MillitaryStatusName, opt => opt.MapFrom(src => src.cmbAskerlikDurumu_TEXT))
                .ForPath(dest => dest.EbaProcessId, opt => opt.MapFrom(src => src.txteBASurecNo));

            CreateMap<IseAlimForeignLanguagesDataGrid, ForeignLanguagesDto>()
                .ForPath(dest => dest.Language.Key, opt => opt.MapFrom(src => src.cmbYabanciDil_dtyYabanciDil))
                .ForPath(dest => dest.Language.Value, opt => opt.MapFrom(src => src.cmbYabanciDil_dtyYabanciDil_TEXT))
                .ForPath(dest => dest.ReadingLevel.Key, opt => opt.MapFrom(src => src.cmbOkumaSeviye_dtyYabanciDil))
                .ForPath(dest => dest.ReadingLevel.Value, opt => opt.MapFrom(src => src.cmbOkumaSeviye_dtyYabanciDil_TEXT))
                .ForPath(dest => dest.WritingLevel.Key, opt => opt.MapFrom(src => src.cmbYazmaSeviye_dtyYabanciDil))
                .ForPath(dest => dest.WritingLevel.Value, opt => opt.MapFrom(src => src.cmbYazmaSeviye_dtyYabanciDil_TEXT))
                .ForPath(dest => dest.SpeakingLevel.Key, opt => opt.MapFrom(src => src.cmbKonusmaSeviye_dtyYabanciDil))
                .ForPath(dest => dest.SpeakingLevel.Value, opt => opt.MapFrom(src => src.cmbKonusmaSeviye_dtyYabanciDil_TEXT));

            CreateMap<IseAlimGeneralSkillsDataGrid, GeneralSkillsDto>()
                .ForPath(dest => dest.GeneralSkill.Key, opt => opt.MapFrom(src => src.cmbGenelYetkinlik_dtyGenelYetkinlik))
                .ForPath(dest => dest.GeneralSkill.Value, opt => opt.MapFrom(src => src.cmbGenelYetkinlik_dtyGenelYetkinlik_TEXT))
                .ForPath(dest => dest.GeneralSkillLevel.Key, opt => opt.MapFrom(src => src.cmbSeviye_dtyGenelYetkinlik))
                .ForPath(dest => dest.GeneralSkillLevel.Value, opt => opt.MapFrom(src => src.cmbSeviye_dtyGenelYetkinlik_TEXT));
        }
    }
}
