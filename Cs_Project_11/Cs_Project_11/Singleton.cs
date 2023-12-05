using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Singleton<T> where T : class, new()
{
    public static T Instance { get; private set; }

    static Singleton()
    {
        if (Singleton<T>.Instance == null)
        {
            Singleton<T>.Instance = new T();
        }
    }
}
