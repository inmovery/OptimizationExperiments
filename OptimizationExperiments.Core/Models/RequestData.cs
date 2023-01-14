namespace OptimizationExperiments.Core.Models;

public readonly struct RequestData
{
    /// <summary>
    /// Идентификатор запроса
    /// </summary>
    public string RequestId { get; init; }

    /// <summary>
    /// Дата запроса
    /// </summary>
    public DateTime RequestDate { get; init; }

    /// <summary>
    /// Человек, участвующий в запросе
    /// </summary>
    public Person Person { get; init; }
}