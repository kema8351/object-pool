using Pool;

namespace PooledObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var intListPool = ListPool<int>.Pool;
            var list = intListPool.Get();
            intListPool.Put(ref list);
        }
    }
}
