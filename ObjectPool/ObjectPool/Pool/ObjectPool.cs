using System.Collections.Generic;

namespace Pool
{
    public class ObjectPool<T> where T : IClearable, new()
    {
        public static ObjectPool<T> Pool { get; } = new ObjectPool<T>();

        Stack<T> pool = new Stack<T>();

        public ObjectPool()
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

    public interface IClearable
    {
        void Clear();
    }
}