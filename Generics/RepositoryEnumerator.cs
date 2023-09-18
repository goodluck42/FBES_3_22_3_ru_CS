using System.Collections;

namespace Generics;

class RepositoryEnumerator<T> : IEnumerator<T>
    where T : class
{
    private readonly List<T> _items;
    private readonly int _length;
    private int _currentIndex;

    public RepositoryEnumerator(List<T> items)
    {
        _items = items;
        _currentIndex = -1;
        _length = _items.Count;
    }
    
    public bool MoveNext()
    {
        if (_currentIndex == _length - 1)
        {
            return false;
        }

        _currentIndex++;

        return true;
    }

    public void Reset()
    {
        _currentIndex = -1;
    }

    public T Current => _items[_currentIndex];

    object IEnumerator.Current => Current;

    public void Dispose() { }
}