namespace OptimizationExperiments.Core.Mappers;

public static class MappingUtils
{
	public static Document GetBirthCertificate(IEnumerable<Document> documents)
	{
		return documents.SingleOrDefault(document => document.Type.Equals(DocumentType.BirthCertificate));
	}

	public static Document GetMasterDocument(IEnumerable<Document> documents)
	{
		return documents.SingleOrDefault(document => document.Type.Equals(DocumentType.Passport));
	}

	public static string GetMasterDocumentDescription(IEnumerable<Document> documents)
	{
		var masterDocument = GetMasterDocument(documents);

		return masterDocument.Type switch
		{
			DocumentType.Passport => "Паспорт",
			DocumentType.BirthCertificate => "Свидительство о рождении",
			DocumentType.EmploymentRecord => "Трудовая книжка",
			DocumentType.SchoolGraduationCertificate => "Диплом о среднем образовании",
			DocumentType.HigherEducationDiploma => "Диплом о высшем образовании",
			DocumentType.Inn => "ИНН",
			DocumentType.Other => "Другое",
			_ => "Что-то пошло не так"
		};
	}

	public static Address GetRegistrationAddress(IEnumerable<Address> addresses)
	{
		return addresses.SingleOrDefault(address => address.Type.Equals(AddressType.Registration));
	}
}