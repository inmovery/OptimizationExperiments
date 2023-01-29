namespace OptimizationExperiments.Core.Models;

public readonly struct SummaryData
{
	/// <summary>
	/// ФИО
	/// </summary>
	public string Fullname { get; init; }

	/// <summary>
	/// Описание человека
	/// </summary>
	public string PersonDescription { get; init; }

	/// <summary>
	/// Информация о рождении
	/// </summary>
	public string BirthInfo { get; init; }

	/// <summary>
	/// Главный документ
	/// </summary>
	public Document MasterDocument { get; init; }

	/// <summary>
	/// Описание главного документа
	/// </summary>
	public string MasterDocumentDescription { get; init; }

	/// <summary>
	/// Дата в определённом формате
	/// </summary>
	public string SpecifiedDate { get; init; }

	/// <summary>
	/// Пол
	/// </summary>
	public Gender Gender { get; init; }

	/// <summary>
	/// Первичная прибыль
	/// </summary>
	public double PrimeIncome { get; init; }

	/// <summary>
	/// Адрес регистрации
	/// </summary>
	public Address RegistrationAddress { get; init; }

	/// <summary>
	/// Свидительство о рождении
	/// </summary>
	public Document BirthCertificate { get; init; }
}