namespace OptimizationExperiments.Core.Models;

public readonly struct Person
{
    /// <summary>
    /// Счастливый ли человек?
    /// </summary>
    public bool IsHappy { get; init; }

    /// <summary>
    /// Имя
    /// </summary>
    public string Firstname { get; init; }

    /// <summary>
    /// Фамилия
    /// </summary>
    public string Lastname { get; init; }

    /// <summary>
    /// Отчество
    /// </summary>
    public string Patronymic { get; init; }

    /// <summary>
    /// Пол
    /// </summary>
    public Gender Gender { get; init; }

    /// <summary>
    /// Количество полных лет (возраст)
    /// </summary>
    public int Age { get; init; }

    /// <summary>
    /// Дата рождения
    /// </summary>
    public DateTime Birthdate { get; init; }

    /// <summary>
    /// Место рождения
    /// </summary>
    public string Birthplace { get; init; }

    /// <summary>
    /// Телефон
    /// </summary>
    public string Phone { get; init; }

    /// <summary>
    /// Почта
    /// </summary>
    public string Email { get; init; }

    /// <summary>
    /// Список документов
    /// </summary>
    public List<Document> Documents { get; init; }

    /// <summary>
    /// Список адресов
    /// </summary>
    public List<Address> Addresses { get; init; }

    /// <summary>
    /// Первичный доход
    /// </summary>
    public double PrimaryIncome { get; init; }
}