using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    class Singleton
    {
        private static Singleton _instance;

        private Singleton()
        {
        }

        public static Singleton Instance()
        {
            if (_instance == null)
            {
                _instance = new Singleton
                {
                    CreationTime = DateTime.Now
                };
            }

            return _instance;
        }

        public DateTime CreationTime { get; private set; }
    }
}
