using System.Collections;

namespace creating_list_use_array.consoleapp;
public class FlexibleArray<T> : IEnumerable<T>, IEnumerator<T>
{
    private T[] _array;
    private int _arraySize;
    private const int _default_capacity = 1000;
    private int _currentIndex;
    private bool _eof;
    private bool _bof;
    private int _capacity => _array.Length;

    public FlexibleArray(int _capacity)
    {
        _array = new T[_capacity];
        Reset();
    }
    public FlexibleArray() : this(_default_capacity)
    {

    }

    public T Current
    {
        get
        {
            if (_currentIndex == -1)
                _currentIndex = 0;
            else if (_currentIndex == _arraySize)
                _currentIndex = _arraySize - 1;

            return _array[_currentIndex];
        }
    }


    public T this[int index] => _array[index];

    public int Add(T item)
    {
        if (_arraySize == _capacity)
        {
            ReSize(_arraySize * 2);
        }

        _array[_arraySize] = item;
        _arraySize++;

        return _arraySize;
    }

    public int AddRange(T[] items)
    {
        if (_arraySize + items.Length >= _capacity)
        {
            ReSize(_arraySize + items.Length);
        }

        for (int i = 0; i < items.Length; i++)
        {
            _array[_arraySize] = items[i];
            _arraySize++;
        }

        return _arraySize;
    }

    public void RemoveAt(int index)
    {
        for (int i = index; i < _arraySize - 1; i++)
        {
            _array[i] = _array[i + 1];
        }

        _arraySize--;
    }



    private void ReSize(int newSize)
    {
        Array.Resize(ref _array, newSize);
    }


    public void Reset()
    {
        SetIndex(-1);
    }

    private void SetCurrent(int increase)
    {
        _currentIndex += increase;
        _eof = _currentIndex > 0 && _currentIndex >= _arraySize - 1;
        _bof = _currentIndex == 0;
    }

    private void SetIndex(int index)
    {
        _currentIndex = 0;
        SetCurrent(index);
    }

    public bool Next()
    {
        if (!_eof)
        {
            SetCurrent(1);
            return true;
        }

        GotoEnd();
        return false;
    }

    public bool Previous()
    {
        if (!_bof)
        {
            SetCurrent(-1);
            return true;
        }

        GotoStart();
        return false;
    }


    public void GotoStart()
    {
        Reset();
    }

    public void GotoEnd()
    {
        SetIndex(_arraySize);
    }

    public void LoadFromArray(T[] newArr)
    {
        Load(newArr);
    }

    private void Load(T[] newArr)
    {
        ArgumentNullException.ThrowIfNull(newArr);
        _array = newArr;
        _arraySize = newArr.Length;
        Reset();
    }

    public IEnumerator<T> GetEnumerator()
    {
        return this;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this;
    }

    public bool MoveNext()
    {
        return Next();
    }

    public void Dispose()
    {
        GC.SuppressFinalize(_array);
    }

    public static implicit operator FlexibleArray<T>(T[] newArr)
    {
        var q = new FlexibleArray<T>();
        q.LoadFromArray(newArr);
        return q;
    }

    object IEnumerator.Current => Current;


}