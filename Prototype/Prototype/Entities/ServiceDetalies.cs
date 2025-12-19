using Prototype.Abstracts;

namespace Prototype.Entities;

/// <summary>
/// Детализация покупки (только для аренды сервера).
/// </summary>
public class ServiceDetalies : IMyCloneable<ServiceDetalies>, ICloneable
{
    public Guid ServiceId { get; set; }
    public Service Service { get; set; }
    
    /// <summary>
    /// Количество камней процессора
    /// </summary>
    public int QuentityCpu { get; set; }
    /// <summary>
    /// Количество гб оперативной памяти
    /// </summary>
    public int QuentityRam { get; set; }
    /// <summary>
    /// Количество гб жесткого диска
    /// </summary>
    public int QuentityHdd { get; set; }
    /// <summary>
    /// Наша настройка сервера? (true - да, false - нет)
    /// </summary>
    public bool IsOurSetting { get; set; }

    public object Clone()
    {
        return MyClone();
    }

    public ServiceDetalies MyClone()
    {
        return (ServiceDetalies)MemberwiseClone();
    }
}
