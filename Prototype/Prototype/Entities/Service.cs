using Prototype.Abstracts;
using Prototype.Enums;

namespace Prototype.Entities;

/// <summary>
/// Предоставляемая услуга
/// </summary>
public class Service : IMyCloneable<Service>, ICloneable
{
    public Guid Id { get; set; }
    /// <summary>
    /// Наименование услуги
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Описание (опционально)
    /// </summary>
    public string? Description { get; set; }
    /// <summary>
    /// Тип услуги
    /// </summary>
    public ServiceTypeEnum ServiceType { get; set; }
    /// <summary>
    /// Ежемесячный платеж
    /// </summary>
    public decimal Payment {  get; set; }

    public ServiceDetalies ServiceDetalies { get; set; }
    public SpecContract SpecContract { get; set; }

    public object Clone()
    {
        return MyClone();
    }

    public Service MyClone()
    {
        var clone = (Service)MemberwiseClone();
        clone.Id = Guid.NewGuid();

        if (this.ServiceDetalies == null)
            return clone;

        clone.ServiceDetalies = ServiceDetalies.MyClone();
        clone.ServiceDetalies.Service = clone;
        clone.ServiceDetalies.ServiceId = clone.Id;

        return clone;
    }
}
