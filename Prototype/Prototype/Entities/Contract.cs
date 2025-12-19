using System.Text;

namespace Prototype.Entities;

/// <summary>
/// Договор
/// </summary>
public class Contract
{
    public Guid Id { get; set; }
    /// <summary>
    /// Контрагент
    /// </summary>
    public Guid ContractorId { get; set; }
    public Contractor Contractor { get; set; }
    /// <summary>
    /// Номер договора
    /// </summary>
    public string Number { get; set; } = string.Empty;
    /// <summary>
    /// Дата подписания договора
    /// </summary>
    public DateTime CreateDate { get; set; }
    /// <summary>
    /// Дата начала действия договора
    /// </summary>
    public DateTime StartDate { get; set; }
    /// <summary>
    /// Дата окончания договора
    /// </summary>
    public DateTime? EndDate { get; set; }
    /// <summary>
    /// Спецификации договора
    /// </summary>
    public ICollection<SpecContract> SpecContracts { get; set; } = new List<SpecContract>();


    public override string ToString()
    {
        var str = new StringBuilder();

        str.Append(Number);

        return str.ToString();
    }

    public void ConsoleWriteLine()
    {
        Console.WriteLine($"Договор: {Number} ({Id})");
        Console.WriteLine($"Контрагент: {Contractor.Name} ({ContractorId})");
        foreach (var spec in SpecContracts) 
        {
            Console.WriteLine($"Спецификация: {spec.Number} ({spec.Id})");
            foreach (var service in spec.Services) 
            {
                Console.WriteLine($"    Услуга: {service.Name} ({service.Id})");
            }
        }
    }
}
