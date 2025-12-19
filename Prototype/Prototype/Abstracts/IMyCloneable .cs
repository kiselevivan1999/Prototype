namespace Prototype.Abstracts;

/// <summary>
/// Интерфейс для реализации паттерна "Прототип"
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IMyCloneable<T> where T : class
{
    public T MyClone();
}