using System.Collections.Generic;
using UnityEngine;

namespace course
{
    public class ClassGeneric : MonoBehaviour
    {
        public List<int> Numbers;
        public List<string> words;

        
        private void Start()
        {
            Numbers = ReverseList(Numbers);
            words = ReverseList(words);
        }

        private List<T> ReverseList<T>(List<T> listtoreverse)
        {
            List<T> Reversedlist = new List<T>();

            for (int i = listtoreverse.Count - 1; i >= 0; i--)
            {
                Reversedlist.Add(listtoreverse[i]);
            }
            return Reversedlist;
        }
    }
}
