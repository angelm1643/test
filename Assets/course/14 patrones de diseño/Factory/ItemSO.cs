using System.Collections.Generic;
using UnityEngine;

namespace course.PatronesDiseno.Factory
{
    [CreateAssetMenu(fileName = "New Item", menuName = "ScriptableObjects/Data/Item", order = 0)]
    public class ItemSO : DataSO
    {
        public Sprite sprite;
        public string title;
        public float price;



    }
}
