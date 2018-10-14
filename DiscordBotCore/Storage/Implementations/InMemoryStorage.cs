using System;
using System.Collections.Generic;

namespace DiscordBotCore.Storage.Implementations
{
    class InMemoryStorage : IDataStorage
    { 
        private readonly Dictionary<string, object> _dictionary = new Dictionary<string, object>();
        private object obj;

        public void StoreObject(object Obj, string key)
        {
            if (_dictionary.ContainsKey(key)) return;
            _dictionary.Add(key, obj);
        }

        public T RestoreObject<T>(string key)
        {
            if (!_dictionary.ContainsKey(key))
                throw new ArgumentException($"The Provided key '{key}' wasn't found.");

            return (T)_dictionary[key];
        }

        public void Hello()
        {
            Console.WriteLine("Hi!");
        }
    }
}
