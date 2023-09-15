namespace Generics;

interface IRepository<T>
{
    void Add(T item);
    void Remove(int id);
    void Remove(Predicate<T> predicate);
    
    T this[int index] { get; }
}