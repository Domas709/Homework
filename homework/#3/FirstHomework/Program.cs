using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Do your testing here.         
            Console.ReadKey();

        }
    }

    public class PhoneBook
    {
        int i = 0;
        String[] array;
        Dictionary<string, int> _phoneBook = new Dictionary<string, int>();
        public PhoneBook(PhoneBookEntry[] initialValues)
        {
            foreach(PhoneBookEntry x in initialValues)
            {
                _phoneBook.Add(x.Name, x.Number);
            }
        }

        public void Add(PhoneBookEntry entry)
        {
            _phoneBook.Add(entry.Name, entry.Number);
        }

        public bool Remove(string name)
        {
            
            _phoneBook.Remove(name);
            return true;
        }

        public bool Update(PhoneBookEntry entry)
        {
            if(_phoneBook.ContainsKey(entry.Name) == true)
            {
                _phoneBook[entry.Name] = entry.Number;
                return true;
            }
            return false;           
        }

        public int Dial(string name)
        {
            if (_phoneBook.ContainsKey(name) == true) 
            {
                return _phoneBook[name];
            }         
            return -1;
        }

        public string[] Name(int number)
        {
            i = 0;
            foreach (KeyValuePair<string, int> entry in _phoneBook)
            {
                if (entry.Value == number)
                {
                    i++;
                }
            }
            array = new string[i];

            i = 0;         
            foreach(KeyValuePair<string, int> entry in _phoneBook)
            {
                if(entry.Value == number)
                {
                    array[i] = entry.Key;
                    i++;
                }
            }
            return array;
        }

        public Dictionary<string, int> Addresses { get { return _phoneBook; } }
    }
}
