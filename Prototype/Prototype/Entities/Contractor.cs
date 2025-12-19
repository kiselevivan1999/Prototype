namespace Prototype.Entities;

/// <summary>
/// Контрагент
/// </summary>
public class Contractor
{
    public Guid Id { get; set; }
    /// <summary>
    /// Наименование
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// ИНН
    /// </summary>
    public string INN { get; set; }
    /// <summary>
    /// КПП
    /// </summary>
    public string KPP { get; set; }
    /// <summary>
    /// Юридический адрес
    /// </summary>
    public string Address { get; set; }
}
