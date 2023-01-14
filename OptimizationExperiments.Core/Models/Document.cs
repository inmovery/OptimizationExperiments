namespace OptimizationExperiments.Core.Models;

public readonly struct Document
{
    /// <summary>
    /// Тип документа
    /// </summary>
    public DocumentType Type { get; init; }

    /// <summary>
    /// Номер документа
    /// </summary>
    public string Number { get; init; }

    /// <summary>
    /// Дата создания документа
    /// </summary>
    public DateTime CreatedAt { get; init; }

    /// <summary>
    /// Тот, кем был создан документ
    /// </summary>
    public Person CreatedBy { get; init; }

    /// <summary>
    /// Стоимость документа
    /// </summary>
    public float Cost { get; init; }
}