using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8;

class CustomList<T> : IEnumerable<T>
{
    private T[] _array = [];

    //private int _capacity = 4;

    public void Add(T t)
    {
        if (t is null)
        {
            throw new NullReferenceException("Parameter cannot be null");
        }

        Array.Resize(ref _array, _array.Length + 1);
        _array[_array.Length - 1] = t;
    }

    public void Remove(T t)
    {

        if (t is null)
        {
            throw new NullReferenceException("Parameter cannot be null");
        }

        int index = Array.IndexOf(_array, t);

        T[] newArray = new T[_array.Length - 1];

        for (int i = 0; i < _array.Length; i++)
        {
            if (i == index)
            {
                continue;
            }

            newArray[i] = _array[i];

        }
        _array = newArray;

    }

    public void Clear()
    {

        _array = [];

    }

    public int Count() { return _array.Length; }

    public delegate bool Check(T obj);

    public T? Find(Predicate<T> match)
    {
        if (match is null)
        {
            throw new NullReferenceException("Parameter cannot be null");
        }

        for (int i = 0; i < _array.Length; i++)
        {

            if (match(_array[i]))
            {
                return _array[i];
            }

        }

        return default;
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var item in _array)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
