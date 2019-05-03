using System.Collections.Generic;

namespace Pool
{
    public class CollectionPool<T, TValue> where T : ICollection<TValue>, new()
    {
        public static CollectionPool<T, TValue> Pool { get; } = new CollectionPool<T, TValue>();

        Stack<T> pool = new Stack<T>();

        public CollectionPool()
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
            t = default(T);
        }
    }
}