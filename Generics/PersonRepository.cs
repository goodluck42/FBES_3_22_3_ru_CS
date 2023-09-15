using System.Collections;

namespace Generics;

class PersonRepository : IRepository<Person>, IEnumerable<Person>
{
    private List<Person> _list;

    public PersonRepository()
    {
        _list = new();
    }
    
    public void Add(Person item)
    {
        _list.Add(item);
    }

    public void Remove(int id)
    {
        _list.RemoveByPredicate(x => x.Id == id);
        
        // ListExtensions.RemoveByPredicate(_list, x => x.Id == id);
        
        // Remove(x => x.Id == id);
    }

    public void Remove(Predicate<Person> predicate)
    {
        _list.RemoveByPredicate(predicate);

        //ListExtensions.RemoveByPredicate(_list, predicate);
    }

    public Person this[int index]
    {
        get
        {
            return _list[index];
        }
    }

    public IEnumerator<Person> GetEnumerator()
    {
        return new RepositoryEnumerator<Person>(_list);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}