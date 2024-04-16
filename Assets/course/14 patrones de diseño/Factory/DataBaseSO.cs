using System;
using System.Collections.Generic;
using UnityEngine;

namespace course.PatronesDiseno.Factory
{
    [CreateAssetMenu(fileName = "New DataBase", menuName = "ScriptableObjects/DataBase", order = 0)]
    public class DataBaseSO : ScriptableObject
    {
        public DataSO[] dataArray;

        private Dictionary<string, DataSO> DataDictionary;

        private void Awake()
        {
            DataDictionary = new Dictionary<string, DataSO>(dataArray.Length);
            Debug.Log($"DataBase '{name}' Awake!");

            if (dataArray.Length == 0) return;

            foreach (var data in dataArray)
            {
                DataDictionary.Add(data.id, data);
            }
        }
        public DataSO GetData(string id)
        {
            if (!DataDictionary.TryGetValue(id, out var data))
            {
                throw new Exception($"Can't Find Data With ID{id}");
            }
            return data;
        }
        public T GetData<T>(string id)
        {

            if (!DataDictionary.TryGetValue(id, out var data))
            {
                throw new Exception($"Can't Find Data With ID{id}");
            }
            T DataGeneric = (T)Convert.ChangeType(data, typeof(T));

            if (DataGeneric == null)
            {
                throw new Exception($"Can't convert data to type{typeof(T)}");
            }
            return DataGeneric;
        }
    }
}
