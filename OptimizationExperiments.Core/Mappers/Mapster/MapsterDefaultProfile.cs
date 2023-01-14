namespace OptimizationExperiments.Core.Mappers.Mapster;

public class MapsterDefaultProfile : IRegister
{
	public void Register(TypeAdapterConfig config)
	{
		config.NewConfig<RequestData, SummaryData>()
			.Map(dest => dest.Fullname, src => $"{src.Person.Lastname} {src.Person.Firstname} {src.Person.Patronymic}")
			.Map(dest => dest.BirthCertificate, src => MappingUtils.GetBirthCertificate(src.Person.Documents))
			.Map(dest => dest.PersonDescription, src => $"Email: {src.Person.Email} Phone: {src.Person.Phone} Happy? {src.Person.IsHappy}")
			.Map(dest => dest.MasterDocument, src => MappingUtils.GetMasterDocument(src.Person.Documents))
			.Map(dest => dest.MasterDocumentDescription, src => MappingUtils.GetMasterDocumentDescription(src.Person.Documents))
			.Map(dest => dest.Gender, src => src.Person)
			.Map(dest => dest.PrimeIncome, src => src.Person.PrimaryIncome)
			.Map(dest => dest.RegistrationAddress, src => MappingUtils.GetRegistrationAddress(src.Person.Addresses))
			.Map(dest => dest.BirthInfo, src => $"Where: {src.Person.Birthplace} When: {src.Person.Birthdate} Full years: {src.Person.Age}")
			.Map(dest => dest.SpecifiedDate, src => src.RequestDate);
	}
}