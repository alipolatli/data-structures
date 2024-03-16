using System.Collections;

namespace creating_list_use_array.consoleapp;

public class FlexibleArray<T> : IEnumerable<T>, IEnumerator<T>
{
    

    public T Current => throw new NotImplementedException();

    object IEnumerator.Current => throw new NotImplementedException();


    public bool MoveNext()
    {
        throw new NotImplementedException();
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }

    public IEnumerator<T> GetEnumerator()
    {
        return this;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this;
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }


    public void Load(T[] array)
    {
        
    }


}