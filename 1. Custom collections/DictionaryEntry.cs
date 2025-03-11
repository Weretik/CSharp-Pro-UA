using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._Custom_collections
{
    public class DictionaryEntry
    {
        public string Russian { get; set; }
        public string English { get; set; }

        public DictionaryEntry(string russian, string english)
        {
            Russian = russian;
            English = english;
        }
    }

    public class MultiLanguageDictionary : IEnumerable<KeyValuePair<string, DictionaryEntry>>
    {
        private Dictionary<string, DictionaryEntry> dictionary;

        public MultiLanguageDictionary()
        {
            dictionary = new Dictionary<string, DictionaryEntry>();
        }

        public void AddWord(string ukrainianWord, string russian, string english)
        {
            dictionary[ukrainianWord] = new DictionaryEntry(russian, english);
        }

        public IEnumerable<string> GetRussianTranslation(string ukrainianWord)
        {
            if (dictionary.ContainsKey(ukrainianWord))
            {
                yield return dictionary[ukrainianWord].Russian;
            }
            else
            {
                yield return "Слово не знайдено";
            }
        }

        public IEnumerable<string> GetEnglishTranslation(string ukrainianWord)
        {
            if (dictionary.ContainsKey(ukrainianWord))
            {
                yield return dictionary[ukrainianWord].English;
            }
            else
            {
                yield return "Слово не знайдено";
            }
        }

        public IEnumerator<KeyValuePair<string, DictionaryEntry>> GetEnumerator()
        {
            foreach (var entry in dictionary)
            {
                yield return entry;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

