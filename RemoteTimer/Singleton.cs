using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteTimer
{
    public class Singleton<T> where T : class, new()
    {
        private static T instance;

        public Singleton()
        {
            instance = new T();
        }

        public static T Instance => instance;
    }
}
