using Prototype.Abstracts;

namespace Prototype.Entities;

/// <summary>
/// Спецификация к договору
/// </summary>
public class SpecContract : IMyCloneable<SpecContract>, ICloneable
{
    public Guid Id { get; set; }
    /// <summary>
    /// Номер спецификации
    /// </summary>
    public string Number { get; set; } = string.Empty;
    /// <summary>
    /// Дата создания спецификации
    /// </summary>
    public DateTime CreateDate { get; set; }
    /// <summary>
    /// Дата начал действия действия спецификации
    /// </summary>
    public DateTime StartDate { get; set; }
    /// <summary>
    /// Дата окончания действия договора
    /// </summary>
    public DateTime? EndDate { get; set; }
    
    /// <summary>
    /// Договор
    /// </summary>
    public Contract Contract { get; set; }
    /// <summary>
    /// Предоставляемые по спецификации услуги
    /// </summary>
    public ICollection<Service> Services { get; set; }

    public object Clone()
    {
        return MyClone();
    }

    public SpecContract MyClone()
    {
        var clone = (SpecContract)MemberwiseClone();
        clone.Id = Guid.NewGuid();
        clone.Number = $"{Number}-Копия";
        clone.CreateDate = DateTime.UtcNow;
        clone.Services = new List<Service>();

        if (Services.Any() is false)
            return clone;

        foreach (var service in Services)
        {
            var cloneService = service.MyClone();
            cloneService.SpecContract = clone;
            clone.Services.Add(cloneService);
        }
        return clone;
    }
}
