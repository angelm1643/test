using UnityEngine;

namespace course.PatronesDiseno.Factory
{
    public class DataBaseFactory
    {
        private DataBaseSO database;
        private DataBaseSO dataBaseSO;

        public DataBaseFactory()
        {

        }

        public DataBaseFactory(DataBaseSO dataBaseSO)
        {
            this.dataBaseSO = dataBaseSO;
        }

        public DataSO GetData(string id)
        {
            return database.GetData(id);
        }
        public ItemSO GetData<ItemSO>(string id)
        {
            return database.GetData<ItemSO>(id);
        }
    }
}
