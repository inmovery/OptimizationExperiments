namespace OptimizationExperiments.Core.Mappers.AutoMapper;

public class AutoMapperDefaultProfile : Profile
{
	public AutoMapperDefaultProfile()
    {
        CreateMap<RequestData, SummaryData>()
            .ForPath(dest => dest.Fullname, act => act.MapFrom(src => $"{src.Person.Lastname} {src.Person.Firstname} {src.Person.Patronymic}"))
            .ForPath(dest => dest.BirthCertificate, act => act.MapFrom(src => MappingUtils.GetBirthCertificate(src.Person.Documents)))
            .ForPath(dest => dest.PersonDescription, act => act.MapFrom(src => $"Email: {src.Person.Email} Phone: {src.Person.Phone} Happy? {src.Person.IsHappy}"))
            .ForPath(dest => dest.MasterDocument, act => act.MapFrom(src => MappingUtils.GetMasterDocument(src.Person.Documents)))
            .ForPath(dest => dest.MasterDocumentDescription, act => act.MapFrom(src => MappingUtils.GetMasterDocumentDescription(src.Person.Documents)))
            .ForPath(dest => dest.Gender, act => act.MapFrom(src => src.Person))
            .ForPath(dest => dest.PrimeIncome, act => act.MapFrom(src => src.Person.PrimaryIncome))
            .ForPath(dest => dest.RegistrationAddress, act => act.MapFrom(src => MappingUtils.GetRegistrationAddress(src.Person.Addresses)))
            .ForPath(dest => dest.BirthInfo, act => act.MapFrom(src => $"Where: {src.Person.Birthplace} When: {src.Person.Birthdate} Full years: {src.Person.Age}"))
            .ForPath(dest => dest.SpecifiedDate, act => act.MapFrom(src => src.RequestDate));
    }
}