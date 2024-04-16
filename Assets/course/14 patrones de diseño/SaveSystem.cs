using UnityEngine;

namespace Course.PatronesDiseno.ServiceAdapter
{
    public class SaveSystem  // only with c#, no unity
    {
        private readonly IDataSaver dataSaver;

        public SaveSystem(IDataSaver dataSaver)
        {
            this.dataSaver = dataSaver;
        }

        public void SaveString(string key, string value)
        {
            dataSaver.SetString(key, value);
        }

        public string LoadString(string key, string defaultValue = "None")
        {
            return dataSaver.GetString(key, defaultValue);
        }

        public void SaveInt(string key, int value)
        {
            dataSaver.SetInt(key, value);
        }

        public int LoadInt(string key, int defaultValue = 0)
        {
            return dataSaver.GetInt(key, defaultValue);
        }
    }
}
