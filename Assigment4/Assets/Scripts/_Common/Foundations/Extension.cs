using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Extensions
{
    public static class Extension
    {
        public static IEnumerable<(T item, int index)> WithIndex<T>(this IEnumerable<T> self)
        => self.Select((item, index) => (item, index));
    }
}