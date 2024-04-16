using UnityEngine;

namespace course.PatronesDiseno.Factory
{
    public class Inventory : MonoBehaviour
    {
        public DataBaseSO ItemDataBase;
        public string ItemID;

        private DataBaseFactory factory;

        private void Start()
        {
            factory = new DataBaseFactory(Instantiate(ItemDataBase));
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                UpdateItem(ItemID);
            }
        }
        private void UpdateItem(string id)
        {
            ItemSO item = factory.GetData<ItemSO>(id);
            Debug.Log($"Item: {item.title},${item.price}");
        }
    }
}
