using System;
using System.Collections.Generic;
using System.Text;

namespace Odev.Dictionary
{
    public class MyDictionary<TKey, TValue>
    {
        private DictionaryObject<TKey, TValue>[] dictionaryObjects;

        public MyDictionary()
        {
            dictionaryObjects = new DictionaryObject<TKey, TValue>[0];
        }

        public void Add(TKey key, TValue value)
        {
            var tempDictionaryObjects = dictionaryObjects;
            dictionaryObjects = new DictionaryObject<TKey, TValue>[dictionaryObjects.Length + 1];

            for (int i = 0; i < tempDictionaryObjects.Length; i++)
            {
                dictionaryObjects[i] = tempDictionaryObjects[i];
            }

            dictionaryObjects[dictionaryObjects.Length - 1] = new DictionaryObject<TKey, TValue> { Key = key, Value = value };
        }

        public int Length
        {
            get { return dictionaryObjects.Length; }
        }

        public TValue[] Values
        {
            get
            {
                TValue[] values = new TValue[dictionaryObjects.Length];
                for (int i = 0; i < dictionaryObjects.Length; i++)
                {
                    values[i] = dictionaryObjects[i].Value;
                }
                return values;
            }
        }

        public class DictionaryObject<TKey, TValue>
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }
        }
    }
}
