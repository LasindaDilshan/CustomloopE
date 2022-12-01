using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomloopE
{
    public static class Extension
    {
        public static CustomIntEnumerator GetEnumerator(this Range range)
        {
            return new CustomIntEnumerator(range);
        }

        public static CustomIntEnumerator GetEnumerator(int range)
        {
            return new CustomIntEnumerator(new Range(0, range));
        }
    }
}
public ref struct CustomIntEnumerator
{
    private int _current;
    private readonly int _end;
    public CustomIntEnumerator(Range range)
    {
        if (range.End.IsFromEnd)
        {
            throw new NotSupportedException();
        }
        _current = range.Start.Value - 1;
        _end = range.End.Value;
    }


    public int Current => _current;

    public bool MoveNext()
    {
        _current++;
        return Current <= _end;
    }



}