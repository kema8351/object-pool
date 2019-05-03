using System.Collections.Generic;

namespace Pool
{
    public class MapPool<T, TKey, TValue> where T : IDictionary<TKey, TValue>, new()
    {
        public static MapPool<T, TKey, TValue> Pool { get; } = new MapPool<T, TKey, TValue>();

        Stack<T> pool = new Stack<T>();

        public MapPool()
        {
        }

        public T Get()
        {
            T result =
                pool.Count <= 0 ?
                new T() :
                pool.Pop();

            result.Clear();

            return result;
        }

        public void Put(ref T t)
        {
            t.Clear();
            pool.Push(t);
        }
    }
}