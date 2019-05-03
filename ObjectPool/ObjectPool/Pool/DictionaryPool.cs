using System.Collections.Generic;

namespace Pool
{
    public class DictionaryPool<TKey, TValue> : MapPool<Dictionary<TKey, TValue>, TKey, TValue>
    {
    }
}