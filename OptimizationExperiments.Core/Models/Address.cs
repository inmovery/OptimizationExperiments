namespace OptimizationExperiments.Core.Models;

public readonly struct Address
{
    /// <summary>
    /// Страна
    /// </summary>
    public string Country { get; init; }

    /// <summary>
    /// Регион
    /// </summary>
    public string Region { get; init; }

    /// <summary>
    /// Город
    /// </summary>
    public string City { get; init; }

    /// <summary>
    /// Район
    /// </summary>
    public string District { get; init; }

    /// <summary>
    /// Название улицы
    /// </summary>
    public string StreetName { get; init; }

    /// <summary>
    /// Номер дома
    /// </summary>
    public int BuildingNumber { get; init; }

    /// <summary>
    /// Дата начала проживания
    /// </summary>
    public DateTime ResidenceStartDate { get; init; }

    /// <summary>
    /// Номер квартиры
    /// </summary>
    public int ApartmentNumber { get; init; }

    /// <summary>
    /// Тип адреса
    /// </summary>
    public AddressType Type { get; init; }

    /// <summary>
    /// Индекс
    /// </summary>
    public string Zip { get; init; }
}